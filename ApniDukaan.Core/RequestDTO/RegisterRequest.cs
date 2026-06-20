using ApniDukaan.Core.Common;

namespace ApniDukaan.Core.RequestDTO
{
    //public record RegisterRequest(
    //    string? Email,
    //    string? Password,
    //    string? PersonName);

    public class RegisterRequest
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PersonName { get; set; }
        public GenderOptions? Gender { get; set; }
    }
}
