﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class pAdvice
    {
        public int ID { get; set; }
        public int pID { get; set; }
        public int uID { get; set; }
        public string valueID { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;


    }
}
