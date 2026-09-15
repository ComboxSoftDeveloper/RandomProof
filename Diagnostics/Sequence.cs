using RandomProof.Types;

namespace RandomProof.Diagnostics;

/// <summary>
/// Последовательность чисел. Отчёт показывает, что с одним начальным
/// значением она повторяется от запуска к запуску, а без него каждый
/// раз новая.
///
/// Это и есть причина, по которой опечатку не стали исправлять: любая
/// правка алгоритма поменяла бы числа у всех, кто задаёт начальное
/// значение.
/// </summary>
internal static class Sequence
{
    /// <summary>Выводит первые числа из разных генераторов.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Первые " + Payloads.Preview + " чисел из диапазона от " + Payloads.Low + " до " + Payloads.High);
        Console.WriteLine();

        Row("new Random(" + Payloads.Seed + ")", new Random(Payloads.Seed));

        Row("ещё раз с тем же значением", new Random(Payloads.Seed));
        Row("new Random(0)", new Random(0));

        Row("new Random()", new Random());
        Row("new Random() ещё раз", new Random());

        Console.WriteLine();
        Console.WriteLine("Две строки с одним начальным значением совпадают, и они же");
        Console.WriteLine("совпадут при следующем запуске программы. Строки без");
        Console.WriteLine("начального значения различаются всегда.");
        Console.WriteLine();

        Console.WriteLine("Дробные числа с тем же начальным значением:");
        Console.WriteLine();

        Random doubles = new(Payloads.Seed);
        Console.Write("  ");

        for (int i = 0; i < Payloads.Preview; i++)
        {
            Console.Write(doubles.NextDouble().ToString("F6") + "  ");
        }

        Console.WriteLine();

        return 0;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static void Row(string name, Random random)
    {
        Console.Write("  " + name.PadRight(32));

        for (int i = 0; i < Payloads.Preview; i++)
        {
            Console.Write(random.Next(Payloads.Low, Payloads.High).ToString().PadLeft(5));
        }

        Console.WriteLine();
    }
}
