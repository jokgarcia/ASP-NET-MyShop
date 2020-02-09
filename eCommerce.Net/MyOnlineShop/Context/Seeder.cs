using MyOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Context
{
    public class Seeder
    {
        public static void Initialize(OnlineShopContext context)
        {
            context.Database.EnsureCreated();

            var customer = new Customer() 
            {
                FirstName = "Jok",
                LastName = "Garcia"
            };

            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
