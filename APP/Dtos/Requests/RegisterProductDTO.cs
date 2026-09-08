namespace APP.Dtos.Requests
{
    public class RegisterProductDTO
    {
        public string Name { get; set; }
        public string Ean { get; set; }
        public int Amount { get; set; }
        public DateOnly Validate { get; set; }
    }
}
