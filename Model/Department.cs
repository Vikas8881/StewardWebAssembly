using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class Department
    {
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public Guid? Guid { get; set; }
        public string Url { get; set; }
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
        public string hospitalID { get; set; }
    }
}
