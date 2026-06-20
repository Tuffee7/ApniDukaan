namespace ApniDukaan.Core.RequestDTO
{
    //public record LoginRequest(
    //    string? Email,
    //    string? Password);

    public class LoginRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
