﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PatientMedicines
    {
        public int ID { get; set; }
        public string? Medicines { get; set; }
        public string? Dose { get; set; }
        public string? when_take { get; set; }
        public string? frequency { get; set; }
        public string? duration { get; set; }
        public string? notes { get; set; }
        public int? Uhid { get; set; }
        public int? Pid { get; set; }
    }
}
