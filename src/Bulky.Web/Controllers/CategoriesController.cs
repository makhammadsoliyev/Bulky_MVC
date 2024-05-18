using Bulky.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Web.Controllers;

public class CategoriesController(BulkyDbContext context) : Controller
{
    public IActionResult Index()
    {
        var categories = context.Categories.ToList();
        return View(categories);
    }
}
