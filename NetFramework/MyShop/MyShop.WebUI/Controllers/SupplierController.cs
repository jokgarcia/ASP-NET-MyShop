using MyShop.Core.Contracts;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    public class SupplierController : Controller
    {
        IRepository<Supplier> context;

        public SupplierController(IRepository<Supplier> SupplierContext)
        {
            this.context = SupplierContext;
        }

        // GET: Supplier
        public ActionResult Index()
        {
            List<Supplier> suppliers = context.Collection().ToList();
            return View(suppliers);
        }

        // GET: Supplier/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            Supplier supplier = new Supplier();
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return View(supplier);
            }
            else
            {
                context.Insert(supplier);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(string id)
        {
            Supplier supplier = context.Find(id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(supplier);
            }
            return View();
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(Supplier supplier, string Id)
        {
            try
            {
                Supplier supplierToEdit = context.Find(Id);
                
                if (supplierToEdit == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    if (!ModelState.IsValid)
                    {
                        return View(supplier);
                    }
                    supplierToEdit.Company = supplier.Company;
                    supplierToEdit.SupplierName = supplier.SupplierName;
                    supplierToEdit.Email = supplier.Email;

                    context.Commit();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(string Id)
        {
            Supplier supplier = context.Find(Id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(supplier);
            }
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Supplier supplier = context.Find(Id);
            try
            {
                if (supplier == null)
                {
                    return HttpNotFound();
                } 
                else
                {
                    context.Delete(Id);
                    context.Commit();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
