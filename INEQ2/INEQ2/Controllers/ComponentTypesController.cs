using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INEQ2.DAL;
using INEQ2.Models;

namespace INEQ2.Controllers
{
    public class ComponentTypesController : Controller
    {
        private DAL.DAL db = new DAL.DAL();

        // GET: ComponentTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.ComponentTypes.ToListAsync());
        }

        // GET: ComponentTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentType componentType = await db.ComponentTypes.FindAsync(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            return View(componentType);
        }

        // GET: ComponentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComponentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Active")] ComponentType componentType)
        {
            if (ModelState.IsValid)
            {
                db.ComponentTypes.Add(componentType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(componentType);
        }

        // GET: ComponentTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentType componentType = await db.ComponentTypes.FindAsync(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            return View(componentType);
        }

        // POST: ComponentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Active")] ComponentType componentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(componentType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(componentType);
        }

        // GET: ComponentTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComponentType componentType = await db.ComponentTypes.FindAsync(id);
            if (componentType == null)
            {
                return HttpNotFound();
            }
            return View(componentType);
        }

        // POST: ComponentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ComponentType componentType = await db.ComponentTypes.FindAsync(id);
            db.ComponentTypes.Remove(componentType);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
