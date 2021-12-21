namespace SerialiersTest.DTO
{
    public class AddressDto
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public StateProvinceDto StateProvince { get; set; }
        public ICollection<BusinessEntityAddressDto> BusinessEntityAddresses { get; set; }
    }
}
