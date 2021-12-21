using Json.Net;
using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;

namespace SerialiersTest.Serializers
{
    public class JsonNetExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonNet.Serialize(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return JsonNet.Deserialize<List<PersonDto>>(text);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return JsonNet.Deserialize<PersonDto>(text);
        }

        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JsonNet.Serialize(person);
        }

        //Simple
        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonNet.Serialize(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return JsonNet.Deserialize<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonNet.Serialize(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonNet.Deserialize<AddressDto>(text);
        }
    }
}
