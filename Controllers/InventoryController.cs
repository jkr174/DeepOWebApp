using System;
using System.Web;
using DeepOWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepOWebApp.Controllers
{
    public class InventoryController : Controller
    {
        private InventoryDbContext db = new InventoryDbContext();
        // GET: Inventory
        
        public ActionResult Index()
        {
            var inventoryies = from e in db.Inventories
                               orderby e.ItemID
                               select e;
            return View(inventoryies);
        }
        // GET: Inventory/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Inventory/Create
        [HttpPost]
        public ActionResult Create(Inventory inv)
        {
            try
            {
                db.Inventories.Add(inv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //GET: Inventory/Edit/5
        public ActionResult Edit(int id)
        {
            var inventory = db.Inventories.Single(m => m.ItemID == id);
            return View(inventory);
        }


        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HttpFormCollection collection)
        {
            try
            {
                var inventory = db.Inventories.Single(m => m.ItemID == id);
                if (TryUpdateModel(inventory))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(inventory);
            }
            catch
            {
                return View();
            }
        }

        //GET: Inventory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //POST: Inventory/Delete/5
        [HttpPost]
        public ActionResult Detele(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add Delete logic here
                return RedirectionToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Inventory> GetInventoryList()
        {
            return new List<Inventory>
            {
                new Inventory
                {
                    ItemID = 1,
                    ItemName = "Hand",


                }
            };
        }
    }
}
