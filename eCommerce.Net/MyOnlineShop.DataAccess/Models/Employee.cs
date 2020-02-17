using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineShop.DataAccess.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string MaritalStatus { get; set; }


    }
}
