using BenchmarkDotNet.Attributes;
using SerialiersTest.Common;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BigComplexJsonBenchmarks : BenchmarkBase
    {
        private readonly string _jsonFile;
        public BigComplexJsonBenchmarks()
        {
            var tc = new TestConstants();
            _jsonFile = tc.BigComplexJsonFileContent;
        }

        [Benchmark]
        public void Utf8Serialize()
        {
            _utf8.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void Utf8Deserialize()
        {
            _utf8.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NewtonSerialize()
        {
            _newton.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void NewtonDeserialize()
        {
            _newton.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void ServiceStackTextSerialize()
        {
            _serviceStackText.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void ServiceStackTextDeserialize()
        {
            _serviceStackText.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JilSerialize()
        {
            _jil.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void JilDeserialize()
        {
            _jil.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NetJSONSerialize()
        {
            _netJSON.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void NetJSONDeserialize()
        {
            _netJSON.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JsonNetSerialize()
        {
            _jsonNet.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void JsonNetDeserialize()
        {
            _jsonNet.BigComplexJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SystemTextJsonSerialize()
        {
            _systemTextJson.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void SystemTextJsonDeserialize()
        {
            _systemTextJson.BigComplexJsonDeserialize(_jsonFile);
        }


        [Benchmark]
        public void SpanJsonSerialize()
        {
            _spanJson.BigComplexJsonSerialize(_constants.People);
        }

        [Benchmark]
        public void SpanJsonDeserialize()
        {
            _spanJson.BigComplexJsonDeserialize(_jsonFile);
        }
    }
}
