using MyShop.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShop.Core.Contracts;
using MyShop.Core.Models;

namespace MyShop.WebUI.Controllers
{
    public class AreaController : Controller
    {
        private readonly IRepository<Area> contextArea;
        
        public AreaController(IRepository<Area> _context)
        {
            this.contextArea = _context;
        }

        // GET: Area
        public ActionResult Index()
        {
            IEnumerable<Area> areas = contextArea.Collection().ToList();
            return View(areas);
        }


        // GET: Area/Create
        public ActionResult Create()
        {
            Area viewModel = new Area();
            //viewModel = new Area();
            return View(viewModel);
        }

        // POST: Area/Create
        [HttpPost]
        public ActionResult Create(Area area)
        {
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            if (!ModelState.IsValid)
            {
                return View(area);
            }
            else
            {

                contextArea.Insert(area);
                contextArea.Commit();

                return RedirectToAction("Index");
            }
        }

        // GET: Area/Edit/5
        public ActionResult Edit(string id)
        {
            Area area = contextArea.Find(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            else
            {
                //viewModel.Area = area;
                return View(area);
            }

        }

        // POST: Area/Edit/5
        [HttpPost]
        public ActionResult Edit(Area area,string id, FormCollection collection)
        {
            Area areaToEdit = contextArea.Find(id);
            if (areaToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(area);
                }

                areaToEdit.Barangay = area.Barangay;
                areaToEdit.CityMunicipality = area.CityMunicipality;
                areaToEdit.Country = area.Country;
                areaToEdit.DeliveryCharges = area.DeliveryCharges;
                areaToEdit.Province = area.Province;
                areaToEdit.Region = area.Region;

                contextArea.Commit();
            }

            return RedirectToAction("Index");
        }

        // GET: Area/Delete/5
        public ActionResult Delete(string id)
        {
            Area area = contextArea.Find(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(area);
            }
        }

        // POST: Area/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string id)
        {
            Area area = contextArea.Find(id);
            if (area == null)
            {
                return HttpNotFound();
            }
            else
            {
                contextArea.Delete(id);
                contextArea.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}
