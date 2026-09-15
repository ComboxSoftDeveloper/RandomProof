using BenchmarkDotNet.Attributes;
using RandomProof.Types;

namespace RandomProof.Benchmarks;

/// <summary>
/// Раздел 1. Получение очередного числа. Три генератора: без начального
/// значения, с ним и общий.
///
/// Генераторы создаются в GlobalSetup: создание замеряется отдельно,
/// у двух конструкторов оно устроено по-разному.
/// </summary>
public class NextBench
{
    private Random _withoutSeed = new();
    private Random _withSeed = new(Payloads.Seed);

    /// <summary>Генераторы готовятся один раз.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _withoutSeed = new Random();
        _withSeed = new Random(Payloads.Seed);
    }

    /// <summary>XoshiroImpl.</summary>
    [Benchmark(Baseline = true)]
    public int WithoutSeed() => Subjects.Next(_withoutSeed);

    /// <summary>Net5CompatSeedImpl, тот самый, с опечаткой.</summary>
    [Benchmark]
    public int WithSeed() => Subjects.Next(_withSeed);

    /// <summary>Общий генератор, по экземпляру на поток.</summary>
    [Benchmark]
    public int Shared() => Subjects.Next(Random.Shared);

    /// <summary>Криптографический генератор.</summary>
    [Benchmark]
    public int Crypto() => Subjects.CryptoNext();
}
