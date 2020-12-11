using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_MVC_Project.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Customer_Name { get; set; }     // Customer Name
        public DateTime DOB { get; set; }
        public string Customer_Address { get; set; }  // CustomerAddress
        public string Customer_Contact { get; set; }  // Customer Contact
    }
}
