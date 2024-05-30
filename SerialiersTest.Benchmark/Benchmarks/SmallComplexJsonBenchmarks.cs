using BenchmarkDotNet.Attributes;
using SerialiersTest.Common;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SmallComplexJsonBenchmarks : BenchmarkBase
    {
        private readonly string _jsonFile;
        public SmallComplexJsonBenchmarks()
        {
            var tc = new TestConstants();
            _jsonFile = tc.SmallComplexJsonFileContent;
        }


        [Benchmark]
        public void NewtonSerialize()
        {
            _newton.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void NewtonDeserialize()
        {
            _newton.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void ServiceStackTextSerialize()
        {
            _serviceStackText.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void ServiceStackTextDeserialize()
        {
            _serviceStackText.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JilSerialize()
        {
            _jil.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void JilJsonDeserialize()
        {
            _jil.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NetJSONSerialize()
        {
            _netJSON.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void NetJSONDeserialize()
        {
            _netJSON.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JsonNetSerialize()
        {
            _jsonNet.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void JsonNetDeserialize()
        {
            _jsonNet.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SystemTextJsonSerialize()
        {
            _systemTextJson.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void SystemTextJsonDeserialize()
        {
            _systemTextJson.SmallComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SpanJsonSerialize()
        {
            _spanJson.SmallComplexJsonSerialize(_constants.Person);
        }

        [Benchmark]
        public void SpanJsonDeserialize()
        {
            _spanJson.SmallComplexJsonDeserialize(_jsonFile);
        }
    }
}
