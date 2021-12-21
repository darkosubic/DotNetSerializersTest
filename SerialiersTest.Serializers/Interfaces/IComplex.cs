using SerialiersTest.DTO;

namespace SerialiersTest.Serializers.Interfaces
{
    public interface IComplex
    {

        string BigComplexJsonSerialize(List<PersonDto> people);
        string SmallComplexJsonSerialize(PersonDto person);
        List<PersonDto> BigComplexJsonDeserialize(string text);
        PersonDto SmallComplexJsonDeserialize(string text);
    }
}
