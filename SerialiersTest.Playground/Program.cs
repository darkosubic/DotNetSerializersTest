using SerialiersTest.Common;
using SerialiersTest.Serializers;

namespace SerialiersTest.Playground
{
    class Program
    {
        private static readonly TestConstants _constants = new();
        private static readonly JilExample _jil = new();
        private static readonly JsonNetExample _jsonNet = new();
        private static readonly NetJSONExample _netJSON = new();
        private static readonly NewtonsoftExample _newtonsoft = new();
        private static readonly ServiceStackTextExample _serviceStackText = new();
        private static readonly SystemTextJsonExample _systemText = new();
        private static readonly Utf8Example _utf8 = new();
        private static readonly SpanJsonExample _spanJson = new();

        static void Main(string[] args)
        {
            JilSerializerTests();
            JsonNetSerializerTests();
            NetJSONSerializerTests();
            NewtonsoftSerializerTests();
            ServiceStackTextSerializerTests();
            SystemTextJsonExampleSerializerTests();
            Utf8ExampleSerializerTests();
            SpanJsonExampleSerializerTests();
        }

        private static void JilSerializerTests()
        {
            var result1 = _jil.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _jil.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _jil.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _jil.BigComplexJsonSerialize(_constants.People);

            var result5 = _jil.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _jil.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _jil.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _jil.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void JsonNetSerializerTests()
        {
            var result1 = _jsonNet.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _jsonNet.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _jsonNet.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _jsonNet.BigComplexJsonSerialize(_constants.People);

            var result5 = _jsonNet.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _jsonNet.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _jsonNet.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _jsonNet.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void NetJSONSerializerTests()
        {
            var result1 = _netJSON.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _netJSON.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _netJSON.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _netJSON.BigComplexJsonSerialize(_constants.People);

            var result5 = _netJSON.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _netJSON.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _netJSON.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _netJSON.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void NewtonsoftSerializerTests()
        {
            var result1 = _newtonsoft.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _newtonsoft.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _newtonsoft.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _newtonsoft.BigComplexJsonSerialize(_constants.People);

            var result5 = _newtonsoft.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _newtonsoft.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _newtonsoft.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _newtonsoft.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void ServiceStackTextSerializerTests()
        {
            var result1 = _serviceStackText.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _serviceStackText.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _serviceStackText.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _serviceStackText.BigComplexJsonSerialize(_constants.People);

            var result5 = _serviceStackText.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _serviceStackText.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _serviceStackText.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _serviceStackText.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void SystemTextJsonExampleSerializerTests()
        {
            var result1 = _systemText.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _systemText.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _systemText.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _systemText.BigComplexJsonSerialize(_constants.People);

            var result5 = _systemText.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _systemText.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _systemText.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _systemText.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void Utf8ExampleSerializerTests()
        {
            var result1 = _utf8.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _utf8.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _utf8.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _utf8.BigComplexJsonSerialize(_constants.People);

            var result5 = _utf8.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _utf8.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _utf8.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _utf8.BigSimpleJsonSerialize(_constants.Addresses);
        }

        private static void SpanJsonExampleSerializerTests()
        {
            var result1 = _spanJson.SmallComplexJsonDeserialize(_constants.SmallSimpleJsonFileContent);
            var result2 = _spanJson.SmallComplexJsonSerialize(_constants.Person);
            var result3 = _spanJson.BigComplexJsonDeserialize(_constants.BigSimpleJsonFileContent);
            var result4 = _spanJson.BigComplexJsonSerialize(_constants.People);

            var result5 = _spanJson.SmallSimpleJsonDeserialize(_constants.SmallComplexJsonFileContent);
            var result6 = _spanJson.SmallSimpleJsonSerialize(_constants.Address);
            var result7 = _spanJson.BigSimpleJsonDeserialize(_constants.BigComplexJsonFileContent);
            var result8 = _spanJson.BigSimpleJsonSerialize(_constants.Addresses);
        }
    }
}
