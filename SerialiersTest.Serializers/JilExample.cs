using Jil;
using SerialiersTest.DTO;
using SerialiersTest.Serializers.Interfaces;

namespace SerialiersTest.Serializers
{
    public class JilExample : ISimple, IComplex
    {
        //To avoid:
        //An exception of type 'Jil.DeserializationException' occurred in Jil.dll but was not handled in user code.
        //Additional information: Expected character: '\'
        private static Options _dateTimeFix = new Options(dateFormat: DateTimeFormat.ISO8601);

        //Complex
        public string BigComplexJsonSerialize(List<PersonDto> people)
        {
            return JSON.Serialize(people);
        }

        public List<PersonDto> BigComplexJsonDeserialize(string text)
        {
            List<PersonDto> result = null;
            using (var input = new StringReader(text))
            {
                result = JSON.Deserialize<List<PersonDto>>(input, _dateTimeFix);
            }

            return result;
        }

        public string SmallComplexJsonSerialize(PersonDto person)
        {
            return JSON.Serialize(person);
        }

        public PersonDto SmallComplexJsonDeserialize(string text)
        {
            PersonDto result = null;
            using (var input = new StringReader(text))
            {
                result = JSON.Deserialize<PersonDto>(input, _dateTimeFix);
            }

            return result;
        }

        //Simple
        public string BigSimpleJsonSerialize(List<AddressDto> addresses)
        {
            return JSON.Serialize(addresses);
        }

        public List<AddressDto> BigSimpleJsonDeserialize(string text)
        {
            List<AddressDto> result = null;
            using (var input = new StringReader(text))
            {
                result = JSON.Deserialize<List<AddressDto>>(input, _dateTimeFix);
            }

            return result;
        }

        public string SmallSimpleJsonSerialize(AddressDto address)
        {
            return JSON.Serialize(address);
        }

        public AddressDto SmallSimpleJsonDeserialize(string text)
        {
            AddressDto result = null;
            using (var input = new StringReader(text))
            {
                result = JSON.Deserialize<AddressDto>(input, _dateTimeFix);
            }

            return result;
        }
    }
}
