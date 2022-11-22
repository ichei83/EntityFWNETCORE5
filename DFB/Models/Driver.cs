using DFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFB.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Address { get; set; }
        public int LicenseExpireDate { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<CarEnrollment> CarEnrollments { get; set; }


    }
}
