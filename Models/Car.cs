using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_MVC_Project.Models
{
    public class Car
    {
        public int Id { get; set; }         // Car ID
        public string Car_Name { get; set; }    // Car Name
        public string Car_Make { get; set; }    // Car Make BY
        public DateTime Car_Date { get; set; }  // Car Manufacturing Date
        public string Car_Price { get; set; }   // Car Price
    }
}
