using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;
using System.Text.Json;

namespace SerialiersTest.Serializers
{
    public class SystemTextJsonExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonSerializer.Serialize(people);
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
            return JsonSerializer.Serialize(person);
        }

        //Simple

        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonSerializer.Serialize(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonSerializer.Serialize(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.Deserialize<AddressDto>(text);
        }
    }
}
