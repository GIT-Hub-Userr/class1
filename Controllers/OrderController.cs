using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        MainEntities db;
        public OrderController()
        {
            db = new MainEntities();
        }
        public ActionResult Index()
        {
            var order_details = db.order.ToList();
            //List<employee_salary_details> all_data = db.employee_salary_details.ToList();
            //return View(all_data);
            return View(order_details);
        }
    }
}