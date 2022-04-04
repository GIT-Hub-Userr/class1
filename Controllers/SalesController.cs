using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using System.Data.Entity;

namespace WebApplication3.Controllers
{
    public class SalesController : Controller
    {
        // GET: employee
        MainEntities db;


        public SalesController()
        {
            db = new MainEntities();
        }

        public ActionResult Index()
        {
            List<sales_table> all_data = db.sales_table.ToList();
            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(sales_table salestable)
        {
            db.sales_table.Add(salestable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int sid)
        {
            sales_table old_data = db.sales_table.Find(sid);//find data using primary key
            //employee_table data = db.employee_table.FirstOrDefault(x => x.id == id); want to find not from id but from other
            return View(old_data); ;
        }
        public ActionResult UpdateData(sales_table sales_table)
        {
            db.Entry(sales_table).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}