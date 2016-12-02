using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class LocationController : Controller
    {
        InventoryEntities1 db = new InventoryEntities1();
        // GET: Location
        public ActionResult Index()
        {
            return View(db.tblLocations.ToList());
        }

        // GET: Location/Details/5
        public ActionResult Details(int? id)
        {
            if (id==null)
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            tblLocation location = db.tblLocations.Find(id);
            if (location == null)
                return HttpNotFound();
            return View(location);
        }

        // GET: Location/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        public ActionResult Create(tblLocation location)
        {
            if (ModelState.IsValid)
            {
                db.tblLocations.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(location);
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            tblLocation location = db.tblLocations.Find(id);
            if (location == null)
                return HttpNotFound();
            return View(location);
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(tblLocation location)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Entry(location).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(location);
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            tblLocation location = db.tblLocations.Find(id);
            if (location == null)
                return HttpNotFound();
            return View(location);
        }

        // POST: Location/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, tblLocation location)
        {
            try
            {
                //tblLocation location=new tblLocation();
               if(ModelState.IsValid)
               {
                   if (id == null) 
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                   location = db.tblLocations.Find(id);
                   if (location == null)
                       return HttpNotFound();
                   db.tblLocations.Remove(location);
                   db.SaveChanges();
                   return RedirectToAction("Index");
               }

                return View(location);
            }
            catch
            {
                return View();
            }
        }
    }
}
