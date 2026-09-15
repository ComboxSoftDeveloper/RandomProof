using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using RandomProof.Types;

namespace RandomProof;

/// <summary>
/// Все измеряемые способы. У каждого NoInlining: иначе компилятор перенесёт
/// код метода в замер и часть работы удалит как ненужную.
///
/// Генераторы создаются заранее и передаются аргументом: создание объекта
/// замеряется отдельно, потому что у двух конструкторов оно устроено
/// по-разному.
/// </summary>
internal static class Subjects
{
    // ---------- получение числа ----------

    /// <summary>Очередное число из генератора.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int Next(Random random) => random.Next();

    /// <summary>Число из диапазона.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int NextRange(Random random) => random.Next(Payloads.Low, Payloads.High);

    /// <summary>Дробное число от нуля до единицы.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static double NextDouble(Random random) => random.NextDouble();

    /// <summary>Длинное число.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static long NextInt64(Random random) => random.NextInt64();

    /// <summary>Заполнение буфера.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void NextBytes(Random random, byte[] buffer) => random.NextBytes(buffer);

    /// <summary>Заполнение того же буфера криптографическим генератором.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void CryptoBytes(byte[] buffer) => RandomNumberGenerator.Fill(buffer);

    /// <summary>Число из криптографического генератора.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int CryptoNext() => RandomNumberGenerator.GetInt32(Payloads.Low, Payloads.High);

    // ---------- создание генератора ----------

    /// <summary>Создание без начального значения.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Random CreateWithoutSeed() => new();

    /// <summary>Создание с начальным значением.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Random CreateWithSeed() => new(Payloads.Seed);
}
