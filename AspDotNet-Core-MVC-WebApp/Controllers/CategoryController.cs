using AspDotNet_Core_MVC_WebApp.Data;
using AspDotNet_Core_MVC_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNet_Core_MVC_WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public IActionResult Index()
        {
            List<Category> objCatogeryList=_dbContext.Catogries.ToList();

            return View(objCatogeryList);
        }
    }
}
