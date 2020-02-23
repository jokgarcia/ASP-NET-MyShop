using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.DataAccess.Models;
using MyOnlineShop.DataAccess.Repository;
using MyOnlineShop.DataAccess.ViewModels;

namespace MyOnlineShop.Controllers
{
    public class CustomerController : Controller
    {
        IOnlineShopRepository onlineShopRepository;
        public CustomerController(IOnlineShopRepository _onlineShopRepository) 
        {
            onlineShopRepository = _onlineShopRepository;
        }
        // GET: Customer
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel();

            var customers = onlineShopRepository.GetCustomers();

            viewModel.Customers = customers;

          return View(viewModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        //[Route("AddCustomer/{Customer}")]
        public IActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    customer.IsActive = true;
                    onlineShopRepository.AddCustomer(customer);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public IActionResult Edit(int Id, string FirstName, string LastName, string Email, string ContactNumber)
        {
            ViewData["Id"] = Id;
            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["Email"] = Email;
            ViewData["ContactNumber"] = ContactNumber;

            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    customer.IsActive = true;
                    onlineShopRepository.UpdateCustomer(customer);
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}