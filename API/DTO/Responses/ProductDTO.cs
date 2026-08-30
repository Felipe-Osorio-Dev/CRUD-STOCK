namespace API.DTO.Responses
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Ean { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
