using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Controllers
{
    public class OrdersController1 : Controller
    {
        public IActionResult Index()
        {
            List<Orders> orders = StaticDb.Orders;
            return View(orders);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Orders orders = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orders == null)
            {
                return new EmptyResult();
            }
            return View(orders);
        }

        [Route("SeeOrders")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Orders");
        }
    }
}
