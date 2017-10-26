using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            ViewBag.Message = "Sports Store App";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is an about page with Angular and netcore Mvc";
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
