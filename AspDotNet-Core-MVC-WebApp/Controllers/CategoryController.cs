using AspDotNet_Core_MVC_WebApp.Data;
using AspDotNet_Core_MVC_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNet_Core_MVC_WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public CategoryController(ApplicationDbContext dbcontext)
        {
            _dbcontext=dbcontext;
        }


        public IActionResult Index()
        {
            List<Category> objCategoryList = _dbcontext.Catogries.ToList();


            return View(objCategoryList);
        }
    }
}
