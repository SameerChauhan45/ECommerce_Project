using ECommerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Project.Controllers
{
    public class ElectronicsController : Controller
    {
        ElectronicsModel electronicsModel = new ElectronicsModel();
        // GET: Electronics Speakers
        public ActionResult Headphones()
        {
            var data = electronicsModel.GetProduct();
            return View(data);
        }

        // GET: Electronics TV
        public ActionResult Tv()
        {
            var data = electronicsModel.GetProduct();
            return View(data);
        }

        // GET: Electronics Watch
        public ActionResult Watch()
        {
            var data = electronicsModel.GetProduct();
            return View(data);
        }
    }
}