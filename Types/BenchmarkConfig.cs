using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Toolchains.CsProj;
using BenchmarkDotNet.Toolchains.DotNetCli;

namespace RandomProof.Types;

public sealed class BenchmarkConfig : ManualConfig
{
    /// <summary>Обычный прогон: со снятием машинного кода.</summary>
    public BenchmarkConfig() : this(true)
    {
    }

    /// <summary>
    /// Прогон с выключенным дизассемблером. Нужен, чтобы отделить сбой самого
    /// замера от сбоя снятия машинного кода: если без дизассемблера замер
    /// проходит, дело в нём, и это надо чинить, а не гадать.
    /// </summary>
    public BenchmarkConfig(bool disassembly)
    {
        // Рантайм задан строкой, а не элементом перечисления CoreRuntime:
        // имена элементов меняются от версии к версии BenchmarkDotNet,
        // а строка "net10.0" читается любой версией одинаково.
        AddJob(Runtime("net8.0", "net8"));
        AddJob(Runtime("net9.0", "net9"));
        AddJob(Runtime("net10.0", "net10").AsBaseline());

        AddDiagnoser(MemoryDiagnoser.Default);

        if (disassembly)
        {
            AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 2, exportGithubMarkdown: true, printSource: false)));
        }

        // Без логгера BenchmarkDotNet не печатает ничего, включая причину,
        // по которой замер не состоялся. Без провайдера колонок сводная таблица
        // выходит пустой: замеры считаются, но показывать их нечем.
        AddLogger(ConsoleLogger.Default);
        AddColumnProvider(DefaultColumnProviders.Instance);

        AddExporter(CsvExporter.Default);
        AddExporter(MarkdownExporter.GitHub);
        AddExporter(HtmlExporter.Default);

        WithArtifactsPath("Bdn");
    }

    /// <summary>Задание для одного рантайма: своя сборка, свой процесс.</summary>
    private static Job Runtime(string moniker, string id) =>
        Job.Default
            .WithToolchain(CsProjCoreToolchain.From(new NetCoreAppSettings(moniker, null, id)))
            .WithId(id);
}
