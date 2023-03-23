// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using FindMostFrequent;

Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run<Implementations>();