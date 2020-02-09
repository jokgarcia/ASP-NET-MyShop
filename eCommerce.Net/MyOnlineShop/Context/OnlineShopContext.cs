using Microsoft.EntityFrameworkCore;
using MyOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Context
{
    public class OnlineShopContext : DbContext
    {
        //COntstructor
        public OnlineShopContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
