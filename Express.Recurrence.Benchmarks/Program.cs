using BenchmarkDotNet.Running;
using Express.Recurrence.Benchmarks;

BenchmarkRunner.Run<Md5VsSha256>();

Console.Read();