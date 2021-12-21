using BenchmarkDotNet.Attributes;
using SerialiersTest.Common;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BigSimpleJsonBenchmarks : BenchmarkBase
    {
        private readonly string _jsonFile;
        public BigSimpleJsonBenchmarks()
        {
            var tc = new TestConstants();
            _jsonFile = tc.BigSimpleJsonFileContent;
        }

        [Benchmark]
        public void Utf8Serialize()
        {
            _utf8.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void Utf8Deserialize()
        {
            _utf8.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NewtonSerialize()
        {
            _newton.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void NewtonDeserialize()
        {
            _newton.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void ServiceStackTextSerialize()
        {
            _serviceStackText.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void ServiceStackTextDeserialize()
        {
            _serviceStackText.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JilSerialize()
        {
            _jil.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void JilDeserialize()
        {
            _jil.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NetJSONSerialize()
        {
            _netJSON.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void NetJSONDeserialize()
        {
            _netJSON.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JsonNetSerialize()
        {
            _jsonNet.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void JsonNetDeserialize()
        {
            _jsonNet.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SystemTextJsonSerialize()
        {
            _systemTextJson.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void SystemTextJsonDeserialize()
        {
            _systemTextJson.BigSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SpanJsonSerialize()
        {
            _spanJson.BigSimpleJsonSerialize(_constants.Addresses);
        }

        [Benchmark]
        public void SpanJsonDeserialize()
        {
            _systemTextJson.BigSimpleJsonDeserialize(_jsonFile);
        }
    }
}
