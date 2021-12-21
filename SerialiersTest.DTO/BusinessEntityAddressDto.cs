using System;

namespace SerialiersTest.DTO
{
    public class BusinessEntityAddressDto
    {
        public int BusinessEntityId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public AddressTypeDto AddressType { get; set; }
        public BusinessEntityDto BusinessEntity { get; set; }
    }
}
