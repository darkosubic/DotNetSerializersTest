using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;

namespace SerialiersTest.Serializers
{
    public class NetJSONExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return NetJSON.NetJSON.Serialize(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return NetJSON.NetJSON.Deserialize<List<PersonDto>>(text);
        }


        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return NetJSON.NetJSON.Serialize(person);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return NetJSON.NetJSON.Deserialize<PersonDto>(text);
        }

        //Simple
        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return NetJSON.NetJSON.Serialize(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            return NetJSON.NetJSON.Deserialize<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return NetJSON.NetJSON.Serialize(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return NetJSON.NetJSON.Deserialize<AddressDto>(text);
        }
    }
}
