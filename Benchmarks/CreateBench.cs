using BenchmarkDotNet.Attributes;

namespace RandomProof.Benchmarks;

/// <summary>
/// Раздел 3. Создание генератора. У двух конструкторов оно устроено
/// по-разному: с начальным значением заполняется массив на 56 чисел,
/// без него берётся готовое состояние.
///
/// Смотреть надо и на время, и на столбец Allocated.
/// </summary>
[MemoryDiagnoser]
public class CreateBench
{
    /// <summary>Создание без начального значения.</summary>
    [Benchmark(Baseline = true)]
    public Random WithoutSeed() => Subjects.CreateWithoutSeed();

    /// <summary>Создание с начальным значением.</summary>
    [Benchmark]
    public Random WithSeed() => Subjects.CreateWithSeed();
}
