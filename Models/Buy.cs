using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_MVC_Project.Models
{
    public class Buy
    {
        public int Id { get; set; }    // Car Buying Id

        public int CustomerId { get; set; }      // Customer ID
        public Customer Customer { get; set; }

        public int StaffId { get; set; }         // Staff ID
        public Staff Staff { get; set; }

        public int CarId { get; set; }           // Car ID
        public Car Car { get; set; }
    }
}
