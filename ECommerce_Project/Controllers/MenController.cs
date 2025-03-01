using ECommerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Project.Controllers
{
    public class MenController : Controller
    {
        //private readonly MenProduct product;
        //MenController()
        //{
        //    product = new MenProduct();
        //}
        MenProduct product = new MenProduct();
        // GET: Men Pants
        public ActionResult Pants()
        {
            var men = product.GetProduct();

            return View(men);
        }

        // GET: Men Shirt
        public ActionResult Shirt()
        {
            var men = product.GetProduct();

            return View(men);
        }

        // GET: Men Shoes
        public ActionResult Shoes()
        {
            var men = product.GetProduct();

            return View(men);
        }
    }
}