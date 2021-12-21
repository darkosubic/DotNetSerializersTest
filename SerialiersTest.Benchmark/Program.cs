using BenchmarkDotNet.Running;
using SerialiersTest.Benchmark.Benchmarks;

namespace SerialiersTest.Benchmark
{
    class Program
    {        
        static void Main(string[] args)
        {
            var benchmarkResult3 = BenchmarkRunner.Run<SmallSimpleJsonBenchmarks>();
            var benchmarkResult1 = BenchmarkRunner.Run<SmallComplexJsonBenchmarks>();
            var benchmarkResult4 = BenchmarkRunner.Run<BigSimpleJsonBenchmarks>();
            var benchmarkResult2 = BenchmarkRunner.Run<BigComplexJsonBenchmarks>();
        }
    }
}
