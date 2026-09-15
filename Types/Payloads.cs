namespace RandomProof.Types;

/// <summary>
/// Общие значения для замеров и отчётов. Собраны в одном месте, чтобы
/// в отчётах и в замерах стояли одни и те же числа.
/// </summary>
internal static class Payloads
{
    /// <summary>Начальное значение, с которого работают все проверки.</summary>
    internal const int Seed = 42;

    /// <summary>Нижняя граница диапазона.</summary>
    internal const int Low = 0;

    /// <summary>Верхняя граница диапазона.</summary>
    internal const int High = 1000;

    /// <summary>Размер буфера для заполнения байтами.</summary>
    internal const int BufferSize = 1024;

    /// <summary>Сколько чисел берётся в проверке распределения.</summary>
    internal const int SampleCount = 10_000_000;

    /// <summary>Сколько корзин в проверке распределения.</summary>
    internal const int Buckets = 10;

    /// <summary>Сколько чисел выводится в отчёте о последовательности.</summary>
    internal const int Preview = 8;

    /// <summary>Сколько потоков берётся в проверке общего генератора.</summary>
    internal const int Threads = 8;

    /// <summary>Сколько чисел берёт каждый поток.</summary>
    internal const int PerThread = 100_000;
}
