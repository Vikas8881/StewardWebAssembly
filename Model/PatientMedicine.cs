using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class PatientMedicine
    {
        public int Id { get; set; }
        public string Medicines { get; set; }
        public string Dose { get; set; }
        public string WhenTake { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }
        public string Notes { get; set; }
        public int? Pid { get; set; }
        public DateTime? Datetime { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string hospitalID { get; set; }
        public string Department { get; set; }
        public string DoctorName { get; set; }
    }
}
