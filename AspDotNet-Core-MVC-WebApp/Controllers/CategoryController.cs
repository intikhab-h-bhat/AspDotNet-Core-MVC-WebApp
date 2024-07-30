using Microsoft.AspNetCore.Mvc;

namespace AspDotNet_Core_MVC_WebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
