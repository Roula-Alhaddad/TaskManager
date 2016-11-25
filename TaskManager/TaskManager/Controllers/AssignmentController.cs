using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManager.Models;
using TaskManager.Context;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Data.Entity;

namespace TaskManager.Controllers
{
    public class AssignmentController : Controller
    {
        private Assignmentcontext db = new Assignmentcontext();
        // GET: Assignment
        public ActionResult index()
        {
            var result = db.Assignments.ToList();
            //return Json(result, JsonRequestBehavior.AllowGet);  
            return View(result);                   
        }

        // GET: Assignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment Assignment = db.Assignments.Find(id);
            if (Assignment == null)
            {
                return HttpNotFound();
            }
            return View(Assignment);
        }
        // GET: Assignment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assignment/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Assignment_Id,Assignment_Name")] Assignment Assignment)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    db.Assignments.Add(Assignment);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Assignment);
            }
            catch
            {
                return View(Assignment);
            }
        }

        // GET: Assignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment Assignment = db.Assignments.Find(id);
            if (Assignment == null)
            {
                return HttpNotFound();
            }
            return View(Assignment);           
        }

        // POST: Assignment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Assignment_Id,Assignment_Name")] Assignment Assignment)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(Assignment).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Assignment);
            }
            catch
            {
                return View(Assignment);
            }                                   
        }

        // GET: Assignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment Assignment = db.Assignments.Find(id);
            if (Assignment == null)
            {
                return HttpNotFound();
            }
            return View(Assignment);

        }

        // POST: Assignment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Assignment Assignment = db.Assignments.Find(id);
                db.Assignments.Remove(Assignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
