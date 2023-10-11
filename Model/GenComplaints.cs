using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class GenComplaints
    {
        [Key]
        public int complainID { get; set; }
        public string? ComplaintsName { get; set; }
        public string? valueID { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
    }
}
