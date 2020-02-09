using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StocksRemaining { get; set; }
        public int StocksQuantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int ConsigneeEmployeeID { get; set; }
    }
}
