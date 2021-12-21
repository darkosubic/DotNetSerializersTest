using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;
using ServiceStack.Text;

namespace SerialiersTest.Serializers
{
    public class ServiceStackTextExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonSerializer.SerializeToString<List<PersonDto>>(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return JsonSerializer.DeserializeFromString<List<PersonDto>>(text);
        }

        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JsonSerializer.SerializeToString<PersonDto>(person);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return JsonSerializer.DeserializeFromString<PersonDto>(text);
        }

        //Simple

        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonSerializer.SerializeToString<List<AddressDto>>(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.DeserializeFromString<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonSerializer.SerializeToString<AddressDto>(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonSerializer.DeserializeFromString<AddressDto>(text);
        }
    }
}
