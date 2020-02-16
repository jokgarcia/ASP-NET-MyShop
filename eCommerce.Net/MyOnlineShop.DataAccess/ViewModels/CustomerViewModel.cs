using MyOnlineShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineShop.DataAccess.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
    }
}
