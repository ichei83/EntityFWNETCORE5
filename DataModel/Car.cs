using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Car
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public DateTime LicenseExpiredDate { get; set; }
    }
}
