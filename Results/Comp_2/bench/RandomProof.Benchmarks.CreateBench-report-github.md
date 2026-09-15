```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean     | Error   | StdDev  | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------ |------ |---------- |---------:|--------:|--------:|------:|--------:|----------:|-------:|----------:|------------:|
| WithoutSeed | net10 | net10     | 118.6 ns | 0.40 ns | 0.31 ns |  1.00 |    0.00 |     555 B | 0.0072 |      72 B |        1.00 |
| WithSeed    | net10 | net10     | 381.3 ns | 3.86 ns | 3.22 ns |  3.22 |    0.03 |     335 B | 0.0300 |     304 B |        4.22 |
| WithoutSeed | net8  | net8      | 122.4 ns | 1.57 ns | 1.31 ns |  1.03 |    0.01 |     155 B | 0.0072 |      72 B |        1.00 |
| WithSeed    | net8  | net8      | 437.1 ns | 3.75 ns | 3.13 ns |  3.69 |    0.03 |     382 B | 0.0300 |     304 B |        4.22 |
| WithoutSeed | net9  | net9      | 120.2 ns | 0.81 ns | 0.68 ns |  1.01 |    0.01 |     150 B | 0.0072 |      72 B |        1.00 |
| WithSeed    | net9  | net9      | 367.3 ns | 4.59 ns | 3.83 ns |  3.10 |    0.03 |     392 B | 0.0300 |     304 B |        4.22 |
