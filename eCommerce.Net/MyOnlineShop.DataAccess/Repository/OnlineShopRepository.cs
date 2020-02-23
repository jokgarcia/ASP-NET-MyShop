using Microsoft.EntityFrameworkCore;
using MyOnlineShop.DataAccess.Context;
using MyOnlineShop.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOnlineShop.DataAccess.Repository
{
    public class OnlineShopRepository : IOnlineShopRepository
    {
        OnlineShopContext context;

        public OnlineShopRepository()
        {

        }

        //Constructor
        public OnlineShopRepository(OnlineShopContext _context)
        {
            context = _context;
        }

        public Customer AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            //"SELECT * FROM Customer"
            return context.Customers.ToList();
        }

        public IEnumerable<Customer> SearchCustomer(string search)
        {
            var result = from c in context.Customers
                         where (c.FirstName.Contains(search))
                         select c;
            return result.ToList();
        }

        public IEnumerable<Customer> SearchCustomer(int Id)
        {
            var result = from c in context.Customers
                         where (c.Id == Id)
                         select c;
            return result.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            context.Attach(customer).State = EntityState.Modified;
            context.SaveChanges();
            return customer;
        }

        public Customer DeleteCustomer(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
