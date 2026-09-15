using RandomProof.Types;

namespace RandomProof.Diagnostics;

/// <summary>
/// Какой алгоритм работает под капотом. Класс Random держит поле с одной
/// из двух реализаций: современной и оставленной ради совместимости.
///
/// Выбор зависит от того, задано начальное значение или нет.
/// </summary>
internal static class Algorithms
{
    /// <summary>Выводит, какая реализация досталась каждому генератору.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("  как создан                     реализация");
        Console.WriteLine();

        Row("new Random()", new Random());

        Row("new Random(" + Payloads.Seed + ")", new Random(Payloads.Seed));
        Row("new Random(0)", new Random(0));

        Row("new Random(int.MaxValue)", new Random(int.MaxValue));
        Row("Random.Shared", Random.Shared);

        Console.WriteLine();
        Console.WriteLine("Без начального значения используется XoshiroImpl — алгоритм,");
        Console.WriteLine("добавленный в .NET 6. С начальным значением —");
        Console.WriteLine("Net5CompatSeedImpl, тот самый, с опечаткой.");
        Console.WriteLine();
        Console.WriteLine("Random.Shared реализацию не показывает: он работает иначе и");
        Console.WriteLine("создаёт отдельный XoshiroImpl для каждого потока.");

        return 0;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static void Row(string name, Random random)
    {
        Console.WriteLine("  " + name.PadRight(32) + Innards.ImplementationName(random));
    }
}
