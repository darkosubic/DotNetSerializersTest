using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using SerialiersTest.Common;
using SerialiersTest.Serializers;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser(true),
        Orderer(SummaryOrderPolicy.FastestToSlowest,
        MethodOrderPolicy.Declared),
        RankColumn(NumeralSystem.Arabic)]
    public abstract class BenchmarkBase
    {
        protected static readonly TestConstants _constants = new();
        protected static readonly NewtonsoftExample _newton = new();
        protected static readonly ServiceStackTextExample _serviceStackText = new();
        protected static readonly NetJSONExample _netJSON = new();
        protected static readonly JsonNetExample _jsonNet = new();
        protected static readonly SystemTextJsonExample _systemTextJson = new();
        protected static readonly JilExample _jil = new();
        protected static readonly SpanJsonExample _spanJson = new();
    }
}