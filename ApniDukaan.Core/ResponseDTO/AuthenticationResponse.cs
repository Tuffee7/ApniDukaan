namespace ApniDukaan.Core.ResponseDTO
{
    public class AuthenticationResponse
    {
        public Guid UserID { get; set; }
        public string? Email { get; set; }
        public string? PersonName { get; set; }
        public string? Token { get; set; }
        public bool? IsAuthenticated { get; set; }
    }
}
