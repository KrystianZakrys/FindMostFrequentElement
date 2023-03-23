``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                                     Method |     Mean |    Error |   StdDev | Rank |     Gen0 |     Gen1 |     Gen2 |  Allocated |
|------------------------------------------- |---------:|---------:|---------:|-----:|---------:|---------:|---------:|-----------:|
|              GetMostFrequentWithDictionary | 69.80 ms | 1.358 ms | 1.617 ms |    1 |        - |        - |        - |      988 B |
| GetMostFrequentWithLinqMixedWithDictionary | 85.91 ms | 1.070 ms | 0.948 ms |    2 | 833.3333 | 666.6667 | 666.6667 | 41949803 B |
|                    GetMostFrequentWithLinq | 89.49 ms | 1.136 ms | 1.007 ms |    3 | 833.3333 | 666.6667 | 666.6667 | 41950181 B |
