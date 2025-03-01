using ECommerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Project.Controllers
{
    public class WomenController : Controller
    {
        WomenModel product = new WomenModel();

        // GET: Women Pants
        public ActionResult Handbags()
        {
            var data = product.GetProduct();
            return View(data);
        }

        // GET: Women Top
        public ActionResult Dresses()
        {
            var data = product.GetProduct();
            return View(data);
        }

        // GET: Women Shoes
        public ActionResult Shoes()
        {
            var data = product.GetProduct();
            return View(data);
        }
    }
}