namespace SerialiersTest.DTO
{
    public class BusinessEntityDto
    {
        public int BusinessEntityId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public PersonDto Person { get; set; }
    }
}
