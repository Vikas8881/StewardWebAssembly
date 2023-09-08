using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Doctor
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string DoctorName { get; set; }
        public int? Fees { get; set; }

        //public List<Patient> Patients { get; set; } = new List<Patient>();
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
        public string hospitalID { get; set; }

    }
}
