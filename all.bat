@echo off
chcp 866 >nul
setlocal enabledelayedexpansion

rem Весь прогон одной командой. Складывает всё в Results\<имя машины>.

rem BenchmarkDotNet собирает вспомогательный проект и передаёт путь в MSBuild
rem без кавычек. Запятая и точка с запятой в пути разбираются как разделители
rem списка свойств, сборка падает с MSB1006, и замеры не выполняются вовсе.
rem Отчёты при этом снимаются нормально, поэтому сбой легко не заметить.
set "PATHCHK=%CD%"
if not "%PATHCHK%"=="%PATHCHK:,=%" goto badpath
if not "%PATHCHK%"=="%PATHCHK:;=%" goto badpath

set NAME=%COMPUTERNAME%
set OUT=Results\%NAME%
if not exist "Results" mkdir "Results"
if not exist "%OUT%" mkdir "%OUT%"
if not exist "%OUT%" (
    echo Не удалось создать папку %OUT%
    goto fail
)

if exist "Bdn\*.log" del /Q "Bdn\*.log" 2>nul

echo Всё ляжет в %OUT%
echo.

rem Папку с отчётами BenchmarkDotNet чистим заранее: если предыдущий прогон
rem оборвали, его процесс мог остаться и держать файл журнала открытым.
if exist "Bdn" rmdir /S /Q "Bdn" 2>nul

echo === Сборка ===
dotnet build -c Release -warnaserror
if errorlevel 1 goto fail

echo.
echo === Сверка на трёх рантаймах ===
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- checks > "%OUT%\checks_%%T.txt"
    if errorlevel 1 (
        echo Сверка не прошла на %%T, смотри "%OUT%\checks_%%T.txt"
        goto fail
    )
)

echo.
echo === Отчёты ===
for %%T in (net8.0 net9.0 net10.0) do (
    for %%R in (algorithms sequence quality) do (
        echo   %%T %%R
        dotnet run -c Release -f %%T --no-build -- %%R > "%OUT%\%%R_%%T.txt"
    )
)

rem Рефлексия и генерация кода складывают мусор в кучу, поэтому замеры
rem снимаются ещё и на серверном сборщике: у него другая работа с памятью.
echo.
echo === На серверном сборщике ===
set DOTNET_gcServer=1
for %%T in (net8.0 net9.0 net10.0) do (
    echo   %%T
    dotnet run -c Release -f %%T --no-build -- checks > "%OUT%\checks_%%T_servergc.txt"
)
set DOTNET_gcServer=

echo.
echo === Проба: один класс без дизассемблера ===
dotnet run -c Release -f net10.0 --no-build -- --filter *NextBench* noasm > "%OUT%\probe_noasm.txt" 2>&1
set PROBE1=%ERRORLEVEL%
if exist "Bdn\RandomProof.log" copy /Y "Bdn\RandomProof.log" "%OUT%\probe_noasm.log" >nul
ping -n 3 127.0.0.1 >nul
if exist "Bdn\*.log" del /Q "Bdn\*.log" 2>nul
if not "%PROBE1%"=="0" echo   завершилось с ошибкой, смотри "%OUT%\probe_noasm.txt"

echo.
echo === Проба: один класс с дизассемблером ===
dotnet run -c Release -f net10.0 --no-build -- --filter *NextBench* > "%OUT%\probe_asm.txt" 2>&1
set PROBE2=%ERRORLEVEL%
if exist "Bdn\RandomProof.log" copy /Y "Bdn\RandomProof.log" "%OUT%\probe_asm.log" >nul
ping -n 3 127.0.0.1 >nul
if exist "Bdn\*.log" del /Q "Bdn\*.log" 2>nul
if not "%PROBE2%"=="0" echo   завершилось с ошибкой, смотри "%OUT%\probe_asm.txt"

echo.
echo === Замеры: каждый класс отдельным запуском ===
echo.
echo   NextBench
dotnet run -c Release -f net10.0 --no-build -- --filter *NextBench*
if errorlevel 1 goto bench_failed

echo   MethodsBench
dotnet run -c Release -f net10.0 --no-build -- --filter *MethodsBench*
if errorlevel 1 goto bench_failed

echo   CreateBench
dotnet run -c Release -f net10.0 --no-build -- --filter *CreateBench*
set MAIN=%ERRORLEVEL%

if exist "Bdn\RandomProof.log" copy /Y "Bdn\RandomProof.log" "%OUT%\bench.log" >nul

if exist "Bdn\results" (
    if not exist "%OUT%\bench" mkdir "%OUT%\bench"
    xcopy /Y /E /I "Bdn\results" "%OUT%\bench" >nul
)

echo.
if not "%MAIN%"=="0" (
    :bench_failed
echo Замеры завершились с ошибкой. Причина в "%OUT%\bench.log".
    goto fail
)

echo Готово. Всё лежит в %OUT%
goto end

:badpath
echo.
echo В пути к проекту есть запятая или точка с запятой:
echo %CD%
echo.
echo BenchmarkDotNet не соберёт вспомогательный проект в таком пути.
echo Перенести проект туда, где этих знаков нет, и запустить снова.
endlocal
exit /b 1

:fail
echo.
echo Прогон остановлен.
endlocal
exit /b 1

:end
endlocal
