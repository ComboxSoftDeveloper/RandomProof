```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| WithoutSeed | net10 | net10     |  2.091 ns | 0.0722 ns | 0.1524 ns |  1.01 |    0.10 |     170 B |         - |          NA |
| WithSeed    | net10 | net10     |  2.470 ns | 0.0275 ns | 0.0229 ns |  1.19 |    0.09 |     215 B |         - |          NA |
| Shared      | net10 | net10     |  3.387 ns | 0.0141 ns | 0.0125 ns |  1.63 |    0.12 |     400 B |         - |          NA |
| Crypto      | net10 | net10     | 72.779 ns | 0.4841 ns | 0.3780 ns | 34.98 |    2.53 |     239 B |         - |          NA |
| WithoutSeed | net8  | net8      |  1.903 ns | 0.0223 ns | 0.0198 ns |  0.91 |    0.07 |     170 B |         - |          NA |
| WithSeed    | net8  | net8      |  2.112 ns | 0.0377 ns | 0.0315 ns |  1.02 |    0.07 |     215 B |         - |          NA |
| Shared      | net8  | net8      |  3.218 ns | 0.0101 ns | 0.0089 ns |  1.55 |    0.11 |     277 B |         - |          NA |
| Crypto      | net8  | net8      | 81.678 ns | 1.6773 ns | 4.0510 ns | 39.26 |    3.43 |     395 B |         - |          NA |
| WithoutSeed | net9  | net9      |  1.955 ns | 0.0129 ns | 0.0114 ns |  0.94 |    0.07 |     170 B |         - |          NA |
| WithSeed    | net9  | net9      |  2.187 ns | 0.0172 ns | 0.0153 ns |  1.05 |    0.08 |     215 B |         - |          NA |
| Shared      | net9  | net9      |  2.797 ns | 0.0140 ns | 0.0117 ns |  1.34 |    0.10 |     271 B |         - |          NA |
| Crypto      | net9  | net9      | 73.393 ns | 0.4778 ns | 0.3990 ns | 35.28 |    2.55 |     371 B |         - |          NA |
