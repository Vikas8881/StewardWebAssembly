using System.ComponentModel.DataAnnotations;

namespace Model.DTO
{
    public class PatientCreateDTO
    {
        public int? Uhid { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        public string Opdtype { get; set; }
        public int Opdfess { get; set; }
        [Required(ErrorMessage = "Please Choose Doctor")]
        public int? DoctorId { get; set; }
        public string? hospitalID { get; set; }
    }
}
