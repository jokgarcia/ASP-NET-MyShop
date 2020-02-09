using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class Supplier
    {
        public long id { get; set; }
        public string CompanyName { get; set; }
        public string tel { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public long CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
