using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;
using SpanJson;

namespace SerialiersTest.Serializers
{
    public class SpanJsonExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonSerializer.Generic.Utf16.Serialize(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return JsonSerializer.Generic.Utf16.Deserialize<List<PersonDto>>(text);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return JsonSerializer.Generic.Utf16.Deserialize<PersonDto>(text);
        }

        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JsonSerializer.Generic.Utf16.Serialize(person);
        }

        //Simple

        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonSerializer.Generic.Utf16.Serialize(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Generic.Utf16.Deserialize<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonSerializer.Generic.Utf16.Serialize(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Generic.Utf16.Deserialize<AddressDto>(text);
        }
    }
}
