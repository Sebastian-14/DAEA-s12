﻿using DOMAIN;
using MVCAJAX.Models;
using SERVICE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAJAX.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();
        // GET: Student

        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                            select new StudentModel
                            {
                                ID = c.studentID,
                                Address = c.studentAddress,
                                Name = c.studentName
                            }
                         ).ToList();
            return View(model);
        }

        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult createStudent(Student std)
        {
            service.Insert(std);
            string message = "SUCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
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

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
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
