using System.ComponentModel.DataAnnotations;

namespace StewardAPI.Dto
{
    public class RegistrationDTO : LoginUserDto
    {
        [Required]
        public string? HospitalID { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]

        public string? Role { get; set; }

    }
}
