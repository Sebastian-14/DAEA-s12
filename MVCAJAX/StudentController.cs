using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERVICE;
using DOMAIN;
using System.Web.Mvc;

namespace MVCAJAX
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();
    // GET: STUDENT

    /*
    public ActionResult IndexRazor()
    {
        var model = (from c in service.Get()
                        select new StudenModel
                     ).ToList();
    }
    */
    }
}