using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Driver
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public int LicenseExpireDate { get; set; }

    }
}
