using MyOnlineShop.DataAccess.Models;
using System.Collections.Generic;

namespace MyOnlineShop.DataAccess.Repository
{
    public interface IOnlineShopRepository
    {
        Customer AddCustomer(Customer customer);
        Customer DeleteCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> SearchCustomer(int Id);
        IEnumerable<Customer> SearchCustomer(string search);
        Customer UpdateCustomer(Customer customer);
    }
}