using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using SerialiersTest.Common;
using SerialiersTest.Serializers;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser(true), Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared), RankColumn(NumeralSystem.Arabic)]
    public abstract class BenchmarkBase
    {
        protected static readonly TestConstants _constants = new TestConstants();
        protected static readonly NewtonsoftExample _newton = new NewtonsoftExample();
        protected static readonly Utf8Example _utf8 = new Utf8Example();
        protected static readonly ServiceStackTextExample _serviceStackText = new ServiceStackTextExample();
        protected static readonly NetJSONExample _netJSON = new NetJSONExample();
        protected static readonly JsonNetExample _jsonNet = new JsonNetExample();
        protected static readonly SystemTextJsonExample _systemTextJson = new SystemTextJsonExample();
        protected static readonly JilExample _jil = new JilExample();
        protected static readonly SpanJsonExample _spanJson = new SpanJsonExample();
    }
}