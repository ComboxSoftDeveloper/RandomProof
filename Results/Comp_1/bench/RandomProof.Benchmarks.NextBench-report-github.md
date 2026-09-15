```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| WithoutSeed | net10 | net10     |  1.590 ns | 0.0154 ns | 0.0144 ns |  1.00 |    0.01 |     170 B |         - |          NA |
| WithSeed    | net10 | net10     |  1.810 ns | 0.0100 ns | 0.0089 ns |  1.14 |    0.01 |     215 B |         - |          NA |
| Shared      | net10 | net10     |  2.532 ns | 0.0584 ns | 0.0546 ns |  1.59 |    0.04 |     400 B |         - |          NA |
| Crypto      | net10 | net10     | 63.589 ns | 1.0929 ns | 1.0223 ns | 39.98 |    0.71 |     239 B |         - |          NA |
| WithoutSeed | net8  | net8      |  1.655 ns | 0.0289 ns | 0.0270 ns |  1.04 |    0.02 |     170 B |         - |          NA |
| WithSeed    | net8  | net8      |  1.802 ns | 0.0333 ns | 0.0312 ns |  1.13 |    0.02 |     215 B |         - |          NA |
| Shared      | net8  | net8      |  2.862 ns | 0.0416 ns | 0.0389 ns |  1.80 |    0.03 |     277 B |         - |          NA |
| Crypto      | net8  | net8      | 61.623 ns | 0.7920 ns | 0.7408 ns | 38.75 |    0.56 |     395 B |         - |          NA |
| WithoutSeed | net9  | net9      |  1.600 ns | 0.0434 ns | 0.0406 ns |  1.01 |    0.03 |     170 B |         - |          NA |
| WithSeed    | net9  | net9      |  1.903 ns | 0.0235 ns | 0.0220 ns |  1.20 |    0.02 |     215 B |         - |          NA |
| Shared      | net9  | net9      |  2.241 ns | 0.0370 ns | 0.0346 ns |  1.41 |    0.02 |     271 B |         - |          NA |
| Crypto      | net9  | net9      | 62.612 ns | 0.3646 ns | 0.3410 ns | 39.37 |    0.40 |     371 B |         - |          NA |
