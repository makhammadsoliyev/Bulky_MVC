using Bulky.Web.Data;
using Bulky.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Web.Controllers;

public class CategoriesController(BulkyDbContext context) : Controller
{
    public IActionResult Index()
    {
        var categories = context.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        /*if (category.Name == category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Name", "The Display Order cannot exactly match the Name");
        }*/

        if (ModelState.IsValid)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("index", "categories");
        }

        return View();
    }

    public IActionResult Edit(long? id)
    {
        if (id is null || id == 0)
            return NotFound();

        var category = context.Categories.Find(id);
        if (category is null)
            return NotFound();

        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            context.Categories.Update(category);
            context.SaveChanges();
            return RedirectToAction("index", "categories");
        }

        return View();
    }

    public IActionResult Delete(long? id)
    {
        if (id is null || id == 0)
            return NotFound();

        var category = context.Categories.Find(id);
        if (category is null)
            return NotFound();

        return View(category);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(long? id)
    {
        var category = context.Categories.Find(id);
        if (category is null)
            return NotFound();

        context.Categories.Remove(category);
        context.SaveChanges();

        return RedirectToAction("index", "categories");
    }
}
