using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class EmployeesalaryController : Controller
    {
        // GET: Employeesalary
        MainEntities db;

        public EmployeesalaryController()
        {
            db = new MainEntities();
        }
        public ActionResult Index()
        {
            var employee_salary_details = db.employee_salary_details.ToList();
            //List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            //return View(all_data);
            return View(employee_salary_details);
        }
        public ActionResult Create()
        {
            var emplist= db.employee_table.ToList();
            ViewBag.employeeList = new SelectList(emplist, "id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult SaveData(employee_salary_details employeesalary)
        {
            db.employee_salary_details.Add(employeesalary);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            employee_salary_details old_data = db.employee_salary_details.Find(id);//find data using primary key
            //employee_table data = db.employee_table.FirstOrDefault(x => x.id == id); want to find not from id but from other
            return View(old_data); ;
        }
    }
}