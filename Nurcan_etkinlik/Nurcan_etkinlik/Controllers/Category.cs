using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Nurcan_etkinlik.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm=new CategoryManager( new EfCategoryRepository());
        public IActionResult Index()
        {
            object values = cm.GetList();
            return View(values);
        }
    }
}
