using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        InventoryEntities1 db = new InventoryEntities1();
        public ActionResult Index()
        {

            return View(db.tblTransactions.ToList());
        }

        // GET: Transaction/Details/5
        
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            tblTransaction tran = new tblTransaction();
            if (tran == null)
                return HttpNotFound();
            return View(tran);
        }

        // GET: Transaction/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
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

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
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

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
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
