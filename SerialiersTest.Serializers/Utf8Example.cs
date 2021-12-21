using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;
using Utf8Json;

namespace SerialiersTest.Serializers
{
    public class Utf8Example : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonSerializer.ToJsonString(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<List<PersonDto>>(text);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<PersonDto>(text);
        }

        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JsonSerializer.ToJsonString(person);
        }

        //Simple
        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonSerializer.ToJsonString(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonSerializer.ToJsonString(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<AddressDto>(text);
        }
    }
}

