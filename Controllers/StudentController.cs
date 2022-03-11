using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        MainEntities db;
        public StudentController()
        {
            db = new MainEntities();
        }
        public ActionResult Index()
        {
            List<studentdetail> all_data = db.studentdetails.ToList();
            return View(all_data);
        }
    }
}