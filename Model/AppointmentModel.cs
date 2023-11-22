using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AppointmentModel
    {
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string phone { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public int? DoctorID { get; set; }
        //public string? Doctor { get; set; }
        //public string AppointmentType { get; set; }
        //public string? confirmation { get; set; }
        //public DateTime starDateTime { get; set; }
        //public DateTime endDateTime { get; set; }
        //public bool Deleted { get; set; } = false;
        //public string? hospitalID { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? DoctorID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Disease { get; set; }
      
        public string? RecurrenceRule { get; set; }
        public string Symptoms { get; set; }
        public bool? IsAllDay { get; set; }
        public string? ElementType { get; set; }
        public bool? IsBlock { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
        public string? RecurrenceException { get; set; }
        public string? hospitalID { get; set; }
        public string AppointmentType { get; set; }
        public bool Deleted { get; set; } = false;

    }
}
