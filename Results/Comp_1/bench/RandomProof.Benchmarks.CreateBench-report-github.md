```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|----------:|------------:|
| WithoutSeed | net10 | net10     |  97.56 ns | 0.775 ns | 0.725 ns |  1.00 |    0.01 | 0.0068 |     555 B |      72 B |        1.00 |
| WithSeed    | net10 | net10     | 240.64 ns | 4.812 ns | 5.910 ns |  2.47 |    0.06 | 0.0286 |     335 B |     304 B |        4.22 |
| WithoutSeed | net8  | net8      |  98.07 ns | 0.904 ns | 0.846 ns |  1.01 |    0.01 | 0.0068 |     155 B |      72 B |        1.00 |
| WithSeed    | net8  | net8      | 289.74 ns | 5.487 ns | 4.864 ns |  2.97 |    0.05 | 0.0286 |     382 B |     304 B |        4.22 |
| WithoutSeed | net9  | net9      |  98.87 ns | 0.943 ns | 0.882 ns |  1.01 |    0.01 | 0.0068 |     153 B |      72 B |        1.00 |
| WithSeed    | net9  | net9      | 301.70 ns | 6.016 ns | 6.928 ns |  3.09 |    0.07 | 0.0286 |     392 B |     304 B |        4.22 |
