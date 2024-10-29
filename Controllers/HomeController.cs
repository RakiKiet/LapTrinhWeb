using Microsoft.AspNetCore.Mvc;

namespace WebsiteCaNhan.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
