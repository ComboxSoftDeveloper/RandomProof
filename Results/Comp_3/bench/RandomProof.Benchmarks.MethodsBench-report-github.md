```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method        | Job   | Toolchain | Mean         | Error      | StdDev     | Median       | Ratio    | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------------- |------ |---------- |-------------:|-----------:|-----------:|-------------:|---------:|--------:|----------:|----------:|------------:|
| RangeWithout  | net10 | net10     |     1.997 ns |  0.0324 ns |  0.0270 ns |     1.994 ns |     1.00 |    0.02 |     309 B |         - |          NA |
| RangeWith     | net10 | net10     |     3.635 ns |  0.0601 ns |  0.0668 ns |     3.625 ns |     1.82 |    0.04 |     258 B |         - |          NA |
| DoubleWithout | net10 | net10     |     3.010 ns |  0.0380 ns |  0.0337 ns |     2.996 ns |     1.51 |    0.03 |     177 B |         - |          NA |
| DoubleWith    | net10 | net10     |     3.637 ns |  0.0739 ns |  0.0655 ns |     3.622 ns |     1.82 |    0.04 |     230 B |         - |          NA |
| Int64Without  | net10 | net10     |     3.206 ns |  0.0424 ns |  0.0376 ns |     3.198 ns |     1.61 |    0.03 |     175 B |         - |          NA |
| Int64With     | net10 | net10     |    33.496 ns |  0.3956 ns |  0.3700 ns |    33.415 ns |    16.78 |    0.28 |     586 B |         - |          NA |
| BytesWithout  | net10 | net10     |   203.598 ns |  3.9344 ns |  4.0403 ns |   202.667 ns |   101.96 |    2.36 |     349 B |         - |          NA |
| BytesWith     | net10 | net10     | 3,110.217 ns | 62.1724 ns | 58.1561 ns | 3,089.091 ns | 1,557.64 |   34.61 |     271 B |         - |          NA |
| BytesCrypto   | net10 | net10     |   459.817 ns |  4.0041 ns |  3.7454 ns |   459.475 ns |   230.28 |    3.48 |     264 B |         - |          NA |
| RangeWithout  | net8  | net8      |     2.050 ns |  0.0272 ns |  0.0254 ns |     2.046 ns |     1.03 |    0.02 |     298 B |         - |          NA |
| RangeWith     | net8  | net8      |     5.482 ns |  0.0673 ns |  0.0630 ns |     5.473 ns |     2.75 |    0.05 |     261 B |         - |          NA |
| DoubleWithout | net8  | net8      |     3.183 ns |  0.0523 ns |  0.0489 ns |     3.165 ns |     1.59 |    0.03 |     179 B |         - |          NA |
| DoubleWith    | net8  | net8      |     4.818 ns |  0.1314 ns |  0.1349 ns |     4.762 ns |     2.41 |    0.07 |     233 B |         - |          NA |
| Int64Without  | net8  | net8      |     3.499 ns |  0.1053 ns |  0.1730 ns |     3.418 ns |     1.75 |    0.09 |     175 B |         - |          NA |
| Int64With     | net8  | net8      |    32.797 ns |  0.3952 ns |  0.3697 ns |    32.601 ns |    16.43 |    0.28 |     673 B |         - |          NA |
| BytesWithout  | net8  | net8      |   184.801 ns |  2.3007 ns |  2.5572 ns |   183.662 ns |    92.55 |    1.73 |     365 B |         - |          NA |
| BytesWith     | net8  | net8      | 3,093.569 ns | 27.5980 ns | 25.8152 ns | 3,094.722 ns | 1,549.30 |   23.55 |     279 B |         - |          NA |
| BytesCrypto   | net8  | net8      |   458.994 ns |  4.3369 ns |  3.6215 ns |   457.691 ns |   229.87 |    3.44 |     275 B |         - |          NA |
| RangeWithout  | net9  | net9      |     2.124 ns |  0.0387 ns |  0.0362 ns |     2.112 ns |     1.06 |    0.02 |     298 B |         - |          NA |
| RangeWith     | net9  | net9      |     4.437 ns |  0.0475 ns |  0.0421 ns |     4.428 ns |     2.22 |    0.04 |     304 B |         - |          NA |
| DoubleWithout | net9  | net9      |     3.279 ns |  0.0894 ns |  0.1311 ns |     3.241 ns |     1.64 |    0.07 |     173 B |         - |          NA |
| DoubleWith    | net9  | net9      |     3.639 ns |  0.0760 ns |  0.0746 ns |     3.622 ns |     1.82 |    0.04 |     230 B |         - |          NA |
| Int64Without  | net9  | net9      |     3.363 ns |  0.0174 ns |  0.0163 ns |     3.362 ns |     1.68 |    0.02 |     175 B |         - |          NA |
| Int64With     | net9  | net9      |    34.075 ns |  0.4085 ns |  0.3821 ns |    33.997 ns |    17.07 |    0.29 |     829 B |         - |          NA |
| BytesWithout  | net9  | net9      |   185.524 ns |  2.2202 ns |  1.9681 ns |   185.479 ns |    92.91 |    1.53 |     346 B |         - |          NA |
| BytesWith     | net9  | net9      | 3,179.525 ns | 32.3452 ns | 28.6732 ns | 3,169.109 ns | 1,592.35 |   24.75 |     271 B |         - |          NA |
| BytesCrypto   | net9  | net9      |   472.970 ns |  9.4421 ns | 12.6050 ns |   467.956 ns |   236.87 |    6.90 |     264 B |         - |          NA |
