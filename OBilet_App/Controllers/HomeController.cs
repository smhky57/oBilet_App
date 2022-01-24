using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private APIController api = new APIController();
        
        public IActionResult Index()
        {
            List<string> ids = api.GetSession();

            ViewBag.Today = DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.Tomorrow = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            ViewBag.SessionId = ids[0];
            ViewBag.DeviceID = ids[1];

            return View();
        }
        [HttpPost]
        public IActionResult Index(Query query)
        {
            return RedirectToAction("Index","Journey", query);
        }
    }
}