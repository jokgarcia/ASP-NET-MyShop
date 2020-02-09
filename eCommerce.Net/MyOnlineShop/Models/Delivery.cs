using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class Delivery
    {
        public int Id {get; set;}

        public string DeliveryName {get; set;}
        public string DeliveryAddress {get; set;}
        public string ContactNumber {get; set;}
        public string DeliveryTime {get; set;}
        public string DeliveryDate {get; set;}
        public string ProductName {get; set;}
        public int OrderNumber {get; set;}

        
    }
}
