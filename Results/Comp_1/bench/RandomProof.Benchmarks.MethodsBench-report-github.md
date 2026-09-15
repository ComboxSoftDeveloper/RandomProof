```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3


```
| Method        | Job   | Toolchain | Mean          | Error      | StdDev     | Ratio    | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------------- |------ |---------- |--------------:|-----------:|-----------:|---------:|--------:|----------:|----------:|------------:|
| RangeWithout  | net10 | net10     |     0.6318 ns |  0.0394 ns |  0.0368 ns |     1.00 |    0.08 |     309 B |         - |          NA |
| RangeWith     | net10 | net10     |     2.4742 ns |  0.0587 ns |  0.0549 ns |     3.93 |    0.23 |     258 B |         - |          NA |
| DoubleWithout | net10 | net10     |     1.9883 ns |  0.0306 ns |  0.0286 ns |     3.16 |    0.18 |     204 B |         - |          NA |
| DoubleWith    | net10 | net10     |     2.0042 ns |  0.0428 ns |  0.0401 ns |     3.18 |    0.18 |     230 B |         - |          NA |
| Int64Without  | net10 | net10     |     1.6958 ns |  0.0107 ns |  0.0089 ns |     2.69 |    0.15 |     175 B |         - |          NA |
| Int64With     | net10 | net10     |    17.4191 ns |  0.0538 ns |  0.0477 ns |    27.65 |    1.49 |     586 B |         - |          NA |
| BytesWithout  | net10 | net10     |   118.9883 ns |  0.2999 ns |  0.2805 ns |   188.89 |   10.16 |     349 B |         - |          NA |
| BytesWith     | net10 | net10     | 2,078.8403 ns |  8.1219 ns |  7.5972 ns | 3,300.08 |  177.65 |     271 B |         - |          NA |
| BytesCrypto   | net10 | net10     |   388.7340 ns |  1.5358 ns |  1.4366 ns |   617.10 |   33.22 |     264 B |         - |          NA |
| RangeWithout  | net8  | net8      |     1.1221 ns |  0.0066 ns |  0.0051 ns |     1.78 |    0.10 |     298 B |         - |          NA |
| RangeWith     | net8  | net8      |     2.3212 ns |  0.0546 ns |  0.0510 ns |     3.68 |    0.21 |     261 B |         - |          NA |
| DoubleWithout | net8  | net8      |     1.8374 ns |  0.0397 ns |  0.0372 ns |     2.92 |    0.17 |     195 B |         - |          NA |
| DoubleWith    | net8  | net8      |     2.1363 ns |  0.0345 ns |  0.0322 ns |     3.39 |    0.19 |     233 B |         - |          NA |
| Int64Without  | net8  | net8      |     1.8349 ns |  0.0610 ns |  0.0968 ns |     2.91 |    0.22 |     175 B |         - |          NA |
| Int64With     | net8  | net8      |    17.0920 ns |  0.0507 ns |  0.0450 ns |    27.13 |    1.46 |     673 B |         - |          NA |
| BytesWithout  | net8  | net8      |   114.7247 ns |  0.4948 ns |  0.4387 ns |   182.12 |    9.81 |     365 B |         - |          NA |
| BytesWith     | net8  | net8      | 2,184.7988 ns | 19.1726 ns | 17.9340 ns | 3,468.29 |  188.33 |     279 B |         - |          NA |
| BytesCrypto   | net8  | net8      |   388.3350 ns |  3.9665 ns |  3.7103 ns |   616.47 |   33.60 |     275 B |         - |          NA |
| RangeWithout  | net9  | net9      |     1.1783 ns |  0.0111 ns |  0.0098 ns |     1.87 |    0.10 |     298 B |         - |          NA |
| RangeWith     | net9  | net9      |     3.9085 ns |  0.0630 ns |  0.0589 ns |     6.20 |    0.35 |     315 B |         - |          NA |
| DoubleWithout | net9  | net9      |     2.0101 ns |  0.0275 ns |  0.0258 ns |     3.19 |    0.18 |     204 B |         - |          NA |
| DoubleWith    | net9  | net9      |     2.1474 ns |  0.0233 ns |  0.0218 ns |     3.41 |    0.19 |     230 B |         - |          NA |
| Int64Without  | net9  | net9      |     1.7353 ns |  0.0430 ns |  0.0402 ns |     2.75 |    0.16 |     175 B |         - |          NA |
| Int64With     | net9  | net9      |    19.9492 ns |  0.2801 ns |  0.2620 ns |    31.67 |    1.75 |     863 B |         - |          NA |
| BytesWithout  | net9  | net9      |   121.5110 ns |  0.1751 ns |  0.1462 ns |   192.89 |   10.37 |     346 B |         - |          NA |
| BytesWith     | net9  | net9      | 2,055.8670 ns |  6.1108 ns |  5.7160 ns | 3,263.61 |  175.52 |     271 B |         - |          NA |
| BytesCrypto   | net9  | net9      |   382.7828 ns |  1.0427 ns |  0.9243 ns |   607.65 |   32.68 |     264 B |         - |          NA |
