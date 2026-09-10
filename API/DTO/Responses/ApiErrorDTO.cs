namespace API.DTO.Responses
{
    public sealed record ApiErrorDTO(int statusCode, string message);
}
