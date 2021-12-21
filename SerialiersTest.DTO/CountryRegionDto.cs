namespace SerialiersTest.DTO
{
    public class CountryRegionDto
    {
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<SalesTerritoryDto> SalesTerritories { get; set; }
        public ICollection<StateProvinceDto> StateProvinces { get; set; }
    }
}
