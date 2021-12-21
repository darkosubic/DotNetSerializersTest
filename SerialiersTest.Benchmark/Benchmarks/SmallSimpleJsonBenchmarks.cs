using BenchmarkDotNet.Attributes;
using SerialiersTest.Common;

namespace SerialiersTest.Benchmark.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SmallSimpleJsonBenchmarks : BenchmarkBase
    {
        private readonly string _jsonFile;
        public SmallSimpleJsonBenchmarks()
        {
            var tc = new TestConstants();
            _jsonFile = tc.SmallSimpleJsonFileContent;
        }

        [Benchmark]
        public void Utf8Serialize()
        {
            _utf8.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void Utf8Deserialize()
        {
            _utf8.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NewtonSerialize()
        {
            _newton.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void NewtonDeserialize()
        {
            _newton.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void ServiceStackTextSerialize()
        {
            _serviceStackText.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void ServiceStackTextDeserialize()
        {
            _serviceStackText.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void JilSerialize()
        {
            _jil.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void JilJsonDeserialize()
        {
            _jil.SmallSimpleJsonDeserialize(_jsonFile);
        }


        [Benchmark]
        public void JsonNetJsonSerialize()
        {
            _jsonNet.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void JsonNetJsonDeserialize()
        {
            _jsonNet.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void NetJSONSerialize()
        {
            _netJSON.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void NetJSONJsonDeserialize()
        {
            _netJSON.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SystemTextJsonSerialize()
        {
            _systemTextJson.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void SystemTextJsonJsonDeserialize()
        {
            _systemTextJson.SmallSimpleJsonDeserialize(_jsonFile);
        }

        [Benchmark]
        public void SpanJsonSerialize()
        {
            _spanJson.SmallSimpleJsonSerialize(_constants.Address);
        }

        [Benchmark]
        public void SpanJsonJsonDeserialize()
        {
            _spanJson.SmallSimpleJsonDeserialize(_jsonFile);
        }
    }
}
