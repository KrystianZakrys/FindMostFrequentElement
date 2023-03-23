``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                                     Method |       Mean |    Error |   StdDev | Rank |       Gen0 |       Gen1 |      Gen2 | Allocated |
|------------------------------------------- |-----------:|---------:|---------:|-----:|-----------:|-----------:|----------:|----------:|
|              GetMostFrequentWithDictionary |   740.0 ms | 14.57 ms | 22.24 ms |    1 |  1000.0000 |  1000.0000 | 1000.0000 | 221.01 MB |
| GetMostFrequentWithLinqMixedWithDictionary | 3,524.5 ms | 61.56 ms | 54.57 ms |    2 | 74000.0000 | 27000.0000 | 4000.0000 | 547.32 MB |
|                    GetMostFrequentWithLinq | 4,264.3 ms | 70.79 ms | 66.22 ms |    3 | 74000.0000 | 27000.0000 | 4000.0000 | 623.52 MB |
