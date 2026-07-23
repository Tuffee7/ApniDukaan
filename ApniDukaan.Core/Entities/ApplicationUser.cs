using System.ComponentModel.DataAnnotations;

namespace ApniDukaan.Core.Entities
{
    public class ApplicationUser
    {
        [Key]
        public Guid UserId { get; set; }

        [StringLength(100)] // NVARCHAR(100)
        public string? Email { get; set; }
        
        [StringLength(50)]
        public string? Password { get; set; }
        
        [StringLength(50)]
        public string? PersonName { get; set; }
        
        [StringLength(10)]
        public string? Gender { get; set; }
    }
}