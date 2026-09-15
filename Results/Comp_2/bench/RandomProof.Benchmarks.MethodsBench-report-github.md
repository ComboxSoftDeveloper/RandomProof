```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method        | Job   | Toolchain | Mean         | Error      | StdDev     | Ratio    | RatioSD | Code Size | Allocated | Alloc Ratio |
|-------------- |------ |---------- |-------------:|-----------:|-----------:|---------:|--------:|----------:|----------:|------------:|
| RangeWithout  | net10 | net10     |     1.477 ns |  0.0295 ns |  0.0246 ns |     1.00 |    0.02 |     309 B |         - |          NA |
| RangeWith     | net10 | net10     |     3.693 ns |  0.0994 ns |  0.1063 ns |     2.50 |    0.08 |     258 B |         - |          NA |
| DoubleWithout | net10 | net10     |     1.977 ns |  0.0677 ns |  0.0633 ns |     1.34 |    0.05 |     177 B |         - |          NA |
| DoubleWith    | net10 | net10     |     2.444 ns |  0.0664 ns |  0.0555 ns |     1.65 |    0.04 |     230 B |         - |          NA |
| Int64Without  | net10 | net10     |     2.491 ns |  0.0806 ns |  0.1019 ns |     1.69 |    0.07 |     175 B |         - |          NA |
| Int64With     | net10 | net10     |    21.439 ns |  0.3037 ns |  0.2840 ns |    14.51 |    0.30 |     586 B |         - |          NA |
| BytesWithout  | net10 | net10     |   189.867 ns |  2.8605 ns |  2.5358 ns |   128.54 |    2.62 |     349 B |         - |          NA |
| BytesWith     | net10 | net10     | 2,462.811 ns | 25.2966 ns | 21.1238 ns | 1,667.35 |   29.75 |     271 B |         - |          NA |
| BytesCrypto   | net10 | net10     |   479.680 ns |  1.7435 ns |  1.3612 ns |   324.75 |    5.21 |     264 B |         - |          NA |
| RangeWithout  | net8  | net8      |     1.448 ns |  0.0077 ns |  0.0060 ns |     0.98 |    0.02 |     298 B |         - |          NA |
| RangeWith     | net8  | net8      |     2.901 ns |  0.0522 ns |  0.0436 ns |     1.96 |    0.04 |     261 B |         - |          NA |
| DoubleWithout | net8  | net8      |     2.242 ns |  0.0728 ns |  0.0747 ns |     1.52 |    0.05 |     179 B |         - |          NA |
| DoubleWith    | net8  | net8      |     3.789 ns |  0.0788 ns |  0.0698 ns |     2.57 |    0.06 |     233 B |         - |          NA |
| Int64Without  | net8  | net8      |     2.346 ns |  0.0317 ns |  0.0281 ns |     1.59 |    0.03 |     175 B |         - |          NA |
| Int64With     | net8  | net8      |    22.641 ns |  0.1630 ns |  0.1445 ns |    15.33 |    0.26 |     673 B |         - |          NA |
| BytesWithout  | net8  | net8      |   132.992 ns |  1.1467 ns |  1.0165 ns |    90.04 |    1.57 |     365 B |         - |          NA |
| BytesWith     | net8  | net8      | 2,593.952 ns | 42.7686 ns | 40.0057 ns | 1,756.14 |   38.20 |     279 B |         - |          NA |
| BytesCrypto   | net8  | net8      |   479.538 ns |  2.1120 ns |  1.7636 ns |   324.65 |    5.26 |     275 B |         - |          NA |
| RangeWithout  | net9  | net9      |     2.205 ns |  0.1076 ns |  0.3171 ns |     1.49 |    0.22 |     298 B |         - |          NA |
| RangeWith     | net9  | net9      |     3.853 ns |  0.0390 ns |  0.0326 ns |     2.61 |    0.05 |     304 B |         - |          NA |
| DoubleWithout | net9  | net9      |     2.150 ns |  0.0075 ns |  0.0066 ns |     1.46 |    0.02 |     173 B |         - |          NA |
| DoubleWith    | net9  | net9      |     3.361 ns |  0.0192 ns |  0.0171 ns |     2.28 |    0.04 |     230 B |         - |          NA |
| Int64Without  | net9  | net9      |     2.383 ns |  0.0707 ns |  0.0626 ns |     1.61 |    0.05 |     175 B |         - |          NA |
| Int64With     | net9  | net9      |    23.298 ns |  0.0864 ns |  0.0766 ns |    15.77 |    0.25 |     829 B |         - |          NA |
| BytesWithout  | net9  | net9      |   188.314 ns |  0.7933 ns |  0.7033 ns |   127.49 |    2.07 |     346 B |         - |          NA |
| BytesWith     | net9  | net9      | 2,451.297 ns | 13.1267 ns | 10.9614 ns | 1,659.56 |   27.20 |     271 B |         - |          NA |
| BytesCrypto   | net9  | net9      |   481.525 ns |  1.9077 ns |  1.6911 ns |   326.00 |    5.27 |     264 B |         - |          NA |
