using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Patient
    {
        public int Id { get; set; }
        public int? Uhid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int DoctorId { get; set; }
        public string Opdtype { get; set; }
        public int Opdfess { get; set; }
        public bool Deleted { get; set; }
        //public virtual Doctor Doctor { get; set; }

        public string hospitalID { get; set; }

    }
}
