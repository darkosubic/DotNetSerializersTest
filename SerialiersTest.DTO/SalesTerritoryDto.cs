namespace SerialiersTest.DTO
{
    public class SalesTerritoryDto
    {
        public int TerritoryId { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYtd { get; set; }
        public decimal CostLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public CountryRegionDto CountryRegionCodeNavigation { get; set; }
        public ICollection<StateProvinceDto> StateProvinces { get; set; }
    }
}
