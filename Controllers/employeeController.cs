using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using System.Data.Entity;

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
        public ActionResult Edit(int id)
        {
            employee_table old_data = db.employee_table.Find(id);//find data using primary key
            //employee_table data = db.employee_table.FirstOrDefault(x => x.id == id); want to find not from id but from other
            return View(old_data); ;
        }
        public ActionResult UpdateData(employee_table employee_table)
        {
            db.Entry(employee_table).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Index(string name)
        {
            var results = db.employee_table.Where(x => x.name == name).ToList();
            return View(results);
        }
        [HttpPost]
        public ActionResult Index(int id,string name)
        { 
            var result=db.employee_table.Where(x=>x.id==id).ToList();
             return View(result);
             var results = db.employee_table.Where(x => x.name == name). ToList();
             return View(results);
        }
    }
}