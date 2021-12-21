using SerialiersTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialiersTest.Serializers.Interfaces
{
    public interface ISimple
    {
        string BigSimpleJsonSerialize(List<AddressDto> addresses);
        List<AddressDto> BigSimpleJsonDeserialize(string text);
        string SmallSimpleJsonSerialize(AddressDto address);
        AddressDto SmallSimpleJsonDeserialize(string text);
    }
}
