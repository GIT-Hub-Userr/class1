using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class teacherController : Controller
    {
        // GET: teacher
        MainEntities db;
        public teacherController()
        {
            db=new MainEntities();
        }
        public ActionResult Index()
        {
            List<teacherdetail> all_data = db.teacherdetails.ToList();
            return View(all_data);
        }
        public ActionResult createT()
        {
            return View();
        }
        public ActionResult SaveData(teacherdetail teacherdetail)
        {
            db.teacherdetails.Add(teacherdetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int tid)
        {
            teacherdetail old_data = db.teacherdetails.Find(tid);//find data using primary key
            //employee_table data = db.employee_table.FirstOrDefault(x => x.id == id); want to find not from id but from other
            return View(old_data); ;
        }
        public ActionResult UpdateData(teacherdetail teacherDetail)
        {
            db.Entry(teacherDetail).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}