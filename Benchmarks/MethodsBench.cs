using BenchmarkDotNet.Attributes;
using RandomProof.Types;

namespace RandomProof.Benchmarks;

/// <summary>
/// Раздел 2. Остальные способы получить случайное значение. Слева
/// XoshiroImpl, справа Net5CompatSeedImpl.
/// </summary>
public class MethodsBench
{
    private Random _withoutSeed = new();
    private Random _withSeed = new(Payloads.Seed);
    private byte[] _buffer = new byte[Payloads.BufferSize];

    /// <summary>Генераторы и буфер готовятся один раз.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _withoutSeed = new Random();

        _withSeed = new Random(Payloads.Seed);
        _buffer = new byte[Payloads.BufferSize];
    }

    /// <summary>Число из диапазона, XoshiroImpl.</summary>
    [Benchmark(Baseline = true)]
    public int RangeWithout() => Subjects.NextRange(_withoutSeed);

    /// <summary>Число из диапазона, Net5CompatSeedImpl.</summary>
    [Benchmark]
    public int RangeWith() => Subjects.NextRange(_withSeed);

    /// <summary>Дробное число, XoshiroImpl.</summary>
    [Benchmark]
    public double DoubleWithout() => Subjects.NextDouble(_withoutSeed);

    /// <summary>Дробное число, Net5CompatSeedImpl.</summary>
    [Benchmark]
    public double DoubleWith() => Subjects.NextDouble(_withSeed);

    /// <summary>Длинное число, XoshiroImpl.</summary>
    [Benchmark]
    public long Int64Without() => Subjects.NextInt64(_withoutSeed);

    /// <summary>Длинное число, Net5CompatSeedImpl.</summary>
    [Benchmark]
    public long Int64With() => Subjects.NextInt64(_withSeed);

    /// <summary>Буфер байт, XoshiroImpl.</summary>
    [Benchmark]
    public void BytesWithout() => Subjects.NextBytes(_withoutSeed, _buffer);

    /// <summary>Буфер байт, Net5CompatSeedImpl.</summary>
    [Benchmark]
    public void BytesWith() => Subjects.NextBytes(_withSeed, _buffer);

    /// <summary>Тот же буфер криптографическим генератором.</summary>
    [Benchmark]
    public void BytesCrypto() => Subjects.CryptoBytes(_buffer);
}
