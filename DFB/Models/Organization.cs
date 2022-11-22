﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFB.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
