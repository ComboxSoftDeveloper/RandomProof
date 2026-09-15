using System.Text;
using BenchmarkDotNet.Running;
using RandomProof.Benchmarks;
using RandomProof.Diagnostics;
using RandomProof.Types;

namespace RandomProof;

/// <summary>
/// Точка входа. Без аргументов запускаются замеры, с именем отчёта — отчёт.
/// </summary>
internal static class Program
{
    /// <summary>Разбор аргументов и запуск.</summary>
    private static int Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string mode = args.Length > 0 ? args[0] : string.Empty;
        return mode switch
        {
            "checks" => Checks.Run(),
            "algorithms" => Algorithms.Run(),
            "sequence" => Sequence.Run(),
            "quality" => Quality.Run(),
            _ => Bench(args),
        };
    }

    /// <summary>Запуск замеров. Аргумент noasm выключает снятие машинного кода.</summary>
    private static int Bench(string[] args)
    {
        bool disassembly = !args.Contains("noasm");
        string[] rest = args.Where(argument => argument != "noasm").ToArray();

        BenchmarkSwitcher
            .FromTypes([typeof(NextBench), typeof(MethodsBench), typeof(CreateBench)])
            .Run(rest, new BenchmarkConfig(disassembly));

        return 0;
    }
}
