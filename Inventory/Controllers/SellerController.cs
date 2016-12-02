using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller
        private InventoryEntities1 db = new InventoryEntities1();
        public ActionResult Index()
        {
            List<object> myModel = new List<object>();
            myModel.Add(db.tblLocations.ToList());
            myModel.Add(db.tblSellers.ToList());
            return View(myModel);
            //var viewModel = from o in db.tblSellers join o2 in db.tblLocations on o.LocationId equals o2.LocationId where o.LocationId.Equals(o2.LocationId) select new InsertSeller { Seller = o, Location = o2 };
            //return View(viewModel);

        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
