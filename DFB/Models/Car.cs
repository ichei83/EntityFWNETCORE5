using DFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFB.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        public string LicenseNumber { get; set; }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public DateTime LicenseExpiredDate { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<CarEnrollment> CarEnrollments { get; set; }
    }
}
