using RandomProof.Types;

namespace RandomProof.Diagnostics;

/// <summary>
/// Качество чисел. Опечатка в алгоритме означает, что обещанный период
/// последовательности не гарантирован, но на простых проверках это
/// не видно — отчёт показывает именно это.
///
/// Берётся распределение по корзинам и связь соседних чисел. Обе проверки
/// грубые: настоящая оценка генератора требует отдельного набора тестов.
/// </summary>
internal static class Quality
{
    /// <summary>Выводит распределение и связь соседних чисел.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine();
        Console.WriteLine("Выборка: " + Payloads.SampleCount + " чисел, " + Payloads.Buckets + " корзин");
        Console.WriteLine();
        Console.WriteLine("  генератор            отклонение от среднего   связь соседних");
        Console.WriteLine();

        Row("new Random()", new Random());

        Row("new Random(" + Payloads.Seed + ")", new Random(Payloads.Seed));
        Row("Random.Shared", Random.Shared);

        Console.WriteLine();
        Console.WriteLine("Отклонение — насколько самая полная корзина отличается от");
        Console.WriteLine("ожидаемой доли. Связь соседних — коэффициент корреляции между");
        Console.WriteLine("числом и следующим за ним: у независимых значений он около нуля.");
        Console.WriteLine();
        Console.WriteLine("Обе проверки грубые и опечатку не ловят. Она сказывается");
        Console.WriteLine("на длине периода, а его проверка требует отдельного набора тестов.");

        return 0;
    }

    /// <summary>Одна строка: равномерность и корреляция.</summary>
    private static void Row(string name, Random random)
    {
        int[] buckets = new int[Payloads.Buckets];
        double sumX = 0;

        double sumY = 0;
        double sumXy = 0;

        double sumXx = 0;
        double sumYy = 0;

        double previous = random.NextDouble();
        for (int i = 0; i < Payloads.SampleCount; i++)
        {
            double current = random.NextDouble();
            buckets[(int)(current * Payloads.Buckets)]++;

            sumX += previous;

            sumY += current;
            sumXy += previous * current;

            sumXx += previous * previous;
            sumYy += current * current;

            previous = current;
        }

        const double expected = (double)Payloads.SampleCount / Payloads.Buckets;
        double worst = 0;

        foreach (int count in buckets)
        {
            double deviation = Math.Abs(count - expected) / expected;
            if (deviation > worst)
            {
                worst = deviation;
            }
        }

        const int number = Payloads.SampleCount;
        double top = number * sumXy - sumX * sumY;

        double bottom = Math.Sqrt((number * sumXx - sumX * sumX) * (number * sumYy - sumY * sumY));
        double correlation = bottom == 0 ? 0 : top / bottom;

        Console.WriteLine("  " + name.PadRight(22)
            + (worst * 100).ToString("F3").PadLeft(18) + " %"
            + correlation.ToString("F6").PadLeft(18));
    }
}
