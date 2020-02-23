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

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}

