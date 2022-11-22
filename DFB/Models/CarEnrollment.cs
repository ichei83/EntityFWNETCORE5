using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFB.Models
{
    public class CarEnrollment
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DriverId { get; set; }

        public Car Car { get; set; }
        public Driver Driver { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public virtual ICollection<Car> Cars { get; set; }


    }
}
