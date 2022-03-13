using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        MainEntities db;


        public employeeController()
        {
            db = new MainEntities();
        }

        public ActionResult Index()
        {
            List<employee_table> all_data = db.employee_table.ToList();
            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(employee_table employeetable)
        {
            db.employee_table.Add(employeetable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}