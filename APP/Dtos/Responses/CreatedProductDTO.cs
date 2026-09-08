namespace APP.Dtos.Responses
{
    internal class CreatedProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Ean { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
