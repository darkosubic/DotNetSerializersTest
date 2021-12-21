# DotNetSerializersTest
.Net Serializers Test

What are we testing?
We are testing speed and memory consumption of multiple .Net serializers. We will test both serialization and deserialization capabilities.

Which serializers are we testing?
ServiceStack.Text.Core, System.Text.Json, Json.Net, Newtonsoft.Json, NetJSON, SpanJson, Jil, Utf8Json

How are we testing?
We will be testing serialization/deserialization of both small and big datasets and with simple and complex types.

What are the requirements to run the tests?
Just Visual Studio 2022 and .Net 6 installed on your machine.

How to run tests?
Set SerialiersTest.Benchmark project as Startup project and run it without debugger. It should take about 20 minutes to run all tests so be patient.

Can I add or modify tests?
Sure. Make sure to extend SerialiersTest.Serializers project with your serializer, and use SerialiersTest.Playground project to test out the results. Pull request with new serializers are most welcome.

What are ISimple and IComplex interfaces?
They make it easier to add new Serializers. Nothing fancy is being done with them.
