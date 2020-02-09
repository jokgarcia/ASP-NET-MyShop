using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double Amount { get; set; }
        public string Category {get; set;}
        public string CreatedBy {get; set;}
        public DateTime CreatedDate { get; set; }
    }
}
