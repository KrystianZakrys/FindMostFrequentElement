``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2728/21H2/November2021Update)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.203
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|                        Method |      Mean |    Error |   StdDev | Rank |      Gen0 |      Gen1 |      Gen2 |    Allocated |
|------------------------------ |----------:|---------:|---------:|-----:|----------:|----------:|----------:|-------------:|
| GetMostFrequentWithDictionary |  67.30 ms | 1.182 ms | 0.987 ms |    1 |         - |         - |         - |      1.04 KB |
|          GetFromStackoverflow |  87.83 ms | 1.710 ms | 2.398 ms |    2 |  833.3333 |  666.6667 |  666.6667 |  40966.16 KB |
|       GetMostFrequentWithLinq | 266.76 ms | 5.323 ms | 9.462 ms |    3 | 2500.0000 | 2000.0000 | 2000.0000 | 122897.76 KB |
