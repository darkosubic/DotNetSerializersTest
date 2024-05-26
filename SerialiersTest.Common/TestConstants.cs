using SerialiersTest.DTO;
using SerialiersTest.Serializers;
using System.Reflection;

namespace SerialiersTest.Common
{
    public class TestConstants
    {
        private const string BigJsonFilePath = "Json\\BigJson.json";
        private const string BigComplexJsonFilePath = "Json\\BigComplexJson.json";
        private const string SmallSimpleJsonFilePath = "Json\\SmallJson.json";
        private const string SmallComplexJsonFilePath = "Json\\SmallComplexJson.json";

        public TestConstants()
        {
            NewtonsoftExample ne = new();
            Addresses = ne.BigSimpleJsonDeserialize(BigComplexJsonFileContent);
            Address = ne.SmallSimpleJsonDeserialize(SmallComplexJsonFileContent);
            People = ne.BigComplexJsonDeserialize(BigSimpleJsonFileContent);
            Person = ne.SmallComplexJsonDeserialize(SmallSimpleJsonFileContent);
        }

        private List<PersonDto> _people;
        public List<PersonDto> People { get => _people; set => _people = value; }

        private PersonDto _person;
        public PersonDto Person { get => _person; set => _person = value; }

        private List<AddressDto> _addresses;
        public List<AddressDto> Addresses { get => _addresses; set => _addresses = value; }

        private AddressDto _address;
        public AddressDto Address { get => _address; set => _address = value; }

        private string _bigJsonFileContent;
        public string BigSimpleJsonFileContent
        {
            get
            {
                if (string.IsNullOrEmpty(_bigJsonFileContent))
                {
                    _bigJsonFileContent = GetFileContent(BigJsonFilePath);
                }

                return _bigJsonFileContent;
            }
        }

        private string _bigComplexJsonFileContent;
        public string BigComplexJsonFileContent
        {
            get
            {
                if (string.IsNullOrEmpty(_bigComplexJsonFileContent))
                {
                    _bigComplexJsonFileContent = GetFileContent(BigComplexJsonFilePath);
                }

                return _bigComplexJsonFileContent;
            }
        }

        private string _smallJsonFileContent;
        public string SmallSimpleJsonFileContent
        {
            get
            {
                if (string.IsNullOrEmpty(_smallJsonFileContent))
                {
                    _smallJsonFileContent = GetFileContent(SmallSimpleJsonFilePath);
                }

                return _smallJsonFileContent;
            }
        }

        private string _smallComplexJsonFileContent;
        public string SmallComplexJsonFileContent
        {
            get
            {
                if (string.IsNullOrEmpty(_smallComplexJsonFileContent))
                {
                    _smallComplexJsonFileContent = GetFileContent(SmallComplexJsonFilePath);
                }

                return _smallComplexJsonFileContent;
            }
        }

        private string GetFileContent(string filePath)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location), filePath);
            return File.ReadAllText(path);
        }
    }
}
