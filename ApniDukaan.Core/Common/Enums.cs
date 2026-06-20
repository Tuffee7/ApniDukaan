using System.ComponentModel.DataAnnotations;

namespace ApniDukaan.Core.Common
{
    public enum GenderOptions
    {
        [Display(Name = "Male")]
        Male,
        [Display(Name = "Female")]
        Female,
        [Display(Name = "Others")]
        Others
    }
}
