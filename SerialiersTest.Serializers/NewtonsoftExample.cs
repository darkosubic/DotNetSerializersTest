using SerialiersTest.DTO;
using Newtonsoft.Json;
using SerialiersTest.Serializers.Interfaces;

namespace SerialiersTest.Serializers
{
    public class NewtonsoftExample : ISimple, IComplex
    {
        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JsonConvert.SerializeObject(people);
        }        

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            return JsonConvert.DeserializeObject<List<PersonDto>>(text);
        }


        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JsonConvert.SerializeObject(person);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            return JsonConvert.DeserializeObject<PersonDto>(text);
        }

        //Simple
        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JsonConvert.SerializeObject(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
             return JsonConvert.DeserializeObject<List<AddressDto>>(text);
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JsonConvert.SerializeObject(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            return JsonConvert.DeserializeObject<AddressDto>(text);
        }
    }
}
