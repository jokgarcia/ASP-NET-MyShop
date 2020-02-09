using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string MaritalStatus { get; set; }


    }
}
