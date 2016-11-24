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

        // GET: Assignment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Assignment/Edit/5
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

        // GET: Assignment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Assignment/Delete/5
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
