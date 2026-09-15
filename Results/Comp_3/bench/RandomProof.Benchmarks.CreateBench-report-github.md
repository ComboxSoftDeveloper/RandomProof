```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean     | Error   | StdDev  | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------ |------ |---------- |---------:|--------:|--------:|------:|--------:|----------:|-------:|----------:|------------:|
| WithoutSeed | net10 | net10     | 126.8 ns | 0.91 ns | 0.76 ns |  1.00 |    0.01 |     555 B | 0.0057 |      72 B |        1.00 |
| WithSeed    | net10 | net10     | 438.3 ns | 7.43 ns | 5.80 ns |  3.46 |    0.05 |     332 B | 0.0238 |     304 B |        4.22 |
| WithoutSeed | net8  | net8      | 130.4 ns | 1.28 ns | 1.07 ns |  1.03 |    0.01 |     155 B | 0.0057 |      72 B |        1.00 |
| WithSeed    | net8  | net8      | 484.4 ns | 3.59 ns | 3.36 ns |  3.82 |    0.03 |     382 B | 0.0238 |     304 B |        4.22 |
| WithoutSeed | net9  | net9      | 133.1 ns | 2.48 ns | 2.20 ns |  1.05 |    0.02 |     150 B | 0.0057 |      72 B |        1.00 |
| WithSeed    | net9  | net9      | 477.8 ns | 5.41 ns | 5.06 ns |  3.77 |    0.04 |     392 B | 0.0238 |     304 B |        4.22 |
