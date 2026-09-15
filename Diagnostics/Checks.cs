using RandomProof.Types;

namespace RandomProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет каждое утверждение статьи на том рантайме, где запущена.
/// Если поведение изменится, прогон это заметит и вернёт код 1.
/// </summary>
internal static class Checks
{
    /// <summary>Сколько чисел сравнивается в проверке последовательностей.</summary>
    private const int Compare = 1000;

    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;
        ok &= ImplementationsDiffer();

        ok &= SeedRepeats();
        ok &= WithoutSeedDiffers();

        ok &= RangesHold();
        ok &= SharedIsSafe();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");

        return ok ? 0 : 1;
    }

    /// <summary>С начальным значением и без него работают разные реализации.</summary>
    private static bool ImplementationsDiffer()
    {
        Console.WriteLine("Реализация под капотом");

        string without = Innards.ImplementationName(new Random());
        string with = Innards.ImplementationName(new Random(Payloads.Seed));

        bool ok = Report("поле _impl читается", !without.Contains("не найдено"), without);
        ok &= Report("с начальным значением другая реализация", without != with, with);

        return ok;
    }

    /// <summary>Одно начальное значение даёт одну последовательность.</summary>
    private static bool SeedRepeats()
    {
        Console.WriteLine();
        Console.WriteLine("Повторяемость с начальным значением");

        Random first = new(Payloads.Seed);
        Random second = new(Payloads.Seed);

        bool same = true;
        for (int i = 0; i < Compare; i++)
        {
            if (first.Next() != second.Next())
            {
                same = false;
                break;
            }
        }

        bool ok = Report("две последовательности совпали", same, Compare + " чисел");

        // Сравнение точное намеренно: проверяется побайтовое совпадение,
        // а не близость значений. Оба генератора выполняют одну и ту же
        // последовательность операций, накопления ошибки тут нет.
        Random doubles1 = new(Payloads.Seed);
        Random doubles2 = new(Payloads.Seed);

        ok &= Report("дробные числа тоже", doubles1.NextDouble() == doubles2.NextDouble(), "");

        Random bytes1 = new(Payloads.Seed);
        Random bytes2 = new(Payloads.Seed);

        byte[] left = new byte[Payloads.BufferSize];
        byte[] right = new byte[Payloads.BufferSize];

        bytes1.NextBytes(left);
        bytes2.NextBytes(right);

        ok &= Report("буфер байт тоже", left.AsSpan().SequenceEqual(right), Payloads.BufferSize + " байт");
        return ok;
    }

    /// <summary>Без начального значения последовательности расходятся.</summary>
    private static bool WithoutSeedDiffers()
    {
        Console.WriteLine();
        Console.WriteLine("Без начального значения");

        Random first = new();
        Random second = new();

        bool different = false;
        for (int i = 0; i < Compare; i++)
        {
            if (first.Next() != second.Next())
            {
                different = true;
                break;
            }
        }

        return Report("два генератора дали разное", different, "");
    }

    /// <summary>Числа не выходят за запрошенные границы.</summary>
    private static bool RangesHold()
    {
        Console.WriteLine();
        Console.WriteLine("Границы диапазонов");

        Random random = new(Payloads.Seed);

        bool inRange = true;
        bool doubleInRange = true;

        for (int i = 0; i < Compare; i++)
        {
            int value = random.Next(Payloads.Low, Payloads.High);
            if (value < Payloads.Low || value >= Payloads.High)
            {
                inRange = false;
            }

            double fraction = random.NextDouble();
            if (fraction < 0 || fraction >= 1)
            {
                doubleInRange = false;
            }
        }

        bool ok = Report("Next в заданных границах", inRange, Payloads.Low + ".." + Payloads.High);

        ok &= Report("NextDouble от нуля до единицы", doubleInRange, "");
        ok &= Report("верхняя граница не достигается", NeverReachesHigh(), "");

        return ok;
    }

    /// <summary>
    /// Общий генератор выдерживает обращение из нескольких потоков.
    /// Обычный Random на это не рассчитан по документации, но на этих
    /// рантаймах порчи состояния добиться не удалось, поэтому проверяется
    /// только Random.Shared.
    /// </summary>
    private static bool SharedIsSafe()
    {
        Console.WriteLine();
        Console.WriteLine("Общий генератор");

        int zeros = 0;

        Thread[] threads = new Thread[Payloads.Threads];
        for (int t = 0; t < threads.Length; t++)
        {
            threads[t] = new Thread(() =>
            {
                int local = 0;
                for (int i = 0; i < Payloads.PerThread; i++)
                {
                    if (Random.Shared.Next(1, Payloads.High) == 0)
                    {
                        local++;
                    }
                }

                Interlocked.Add(ref zeros, local);
            });

            threads[t].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        return Report("Random.Shared не выдал ни одного нуля", zeros == 0, zeros.ToString());
    }

    /// <summary>Верхняя граница диапазона не попадается ни разу.</summary>
    private static bool NeverReachesHigh()
    {
        Random random = new(Payloads.Seed);
        for (int i = 0; i < Compare * 100; i++)
        {
            if (random.Next(Payloads.Low, Payloads.High) == Payloads.High)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static bool Report(string name, bool ok, string detail)
    {
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + (detail.Length == 0 ? "" : ": " + detail));
        return ok;
    }
}
