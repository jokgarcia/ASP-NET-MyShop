using Microsoft.EntityFrameworkCore;
using MyOnlineShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOnlineShop.DataAccess.Context
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

