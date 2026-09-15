```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method      | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------ |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| WithoutSeed | net10 | net10     |  3.240 ns | 0.0267 ns | 0.0250 ns |  3.234 ns |  1.00 |    0.01 |     170 B |         - |          NA |
| WithSeed    | net10 | net10     |  3.308 ns | 0.0286 ns | 0.0268 ns |  3.304 ns |  1.02 |    0.01 |     215 B |         - |          NA |
| Shared      | net10 | net10     |  3.993 ns | 0.0316 ns | 0.0296 ns |  3.984 ns |  1.23 |    0.01 |     395 B |         - |          NA |
| Crypto      | net10 | net10     | 70.485 ns | 0.6408 ns | 0.5994 ns | 70.232 ns | 21.76 |    0.24 |     239 B |         - |          NA |
| WithoutSeed | net8  | net8      |  3.214 ns | 0.0406 ns | 0.0317 ns |  3.213 ns |  0.99 |    0.01 |     170 B |         - |          NA |
| WithSeed    | net8  | net8      |  3.270 ns | 0.0157 ns | 0.0131 ns |  3.271 ns |  1.01 |    0.01 |     215 B |         - |          NA |
| Shared      | net8  | net8      |  4.078 ns | 0.0314 ns | 0.0294 ns |  4.083 ns |  1.26 |    0.01 |     272 B |         - |          NA |
| Crypto      | net8  | net8      | 73.361 ns | 0.5906 ns | 0.4932 ns | 73.494 ns | 22.64 |    0.22 |     395 B |         - |          NA |
| WithoutSeed | net9  | net9      |  3.179 ns | 0.0354 ns | 0.0331 ns |  3.174 ns |  0.98 |    0.01 |     170 B |         - |          NA |
| WithSeed    | net9  | net9      |  3.292 ns | 0.0601 ns | 0.0502 ns |  3.280 ns |  1.02 |    0.02 |     215 B |         - |          NA |
| Shared      | net9  | net9      |  3.674 ns | 0.1270 ns | 0.3744 ns |  3.533 ns |  1.13 |    0.12 |     266 B |         - |          NA |
| Crypto      | net9  | net9      | 77.286 ns | 1.0821 ns | 1.0122 ns | 76.888 ns | 23.86 |    0.35 |     371 B |         - |          NA |
