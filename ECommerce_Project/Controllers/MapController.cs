using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ECommerce_Project.Controllers
{
    public class MapController : Controller
    {
        // private string apiKey = "AIzaSyBJ4WOxBOiA0otIOzZMmME4a97n3CVicC8";

        //public async Task<ActionResult> GetCoordinates(string address)
        //{
        //    string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(address)}&key={apiKey}";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync(url);
        //        string result = await response.Content.ReadAsStringAsync();
        //        return Content(result, "application/json");
        //    }
        //}
        // GET: Map
        public ActionResult Index()
        {
            ViewBag.GoMapsApiKey = ConfigurationManager.AppSettings["GoMapsApiKey"];
            return View();
        }
    }
}