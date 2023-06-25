
using Bulky.Models;
using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public AppDbContext _db { get;set; }
        public List<Category> categories { get; set; }
        public Category Category { get; set; }

        public CategoryController(AppDbContext db) 
        {
            _db = db;
        }
        #region Index
        public IActionResult Index()
        {
            categories = _db.Category.ToList();
            return View(categories);
        }

        #endregion

        #region Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _db.Category.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(); 
        }

		#endregion

		#region Delete

        public IActionResult Delete(int id) 
        {
            Category = _db.Category.FirstOrDefault(c => c.Id == id);
            return View(Category);
        }

        [HttpPost]
        public IActionResult Delete(Category category) 
        {
            _db.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

		#endregion

		#region Edit
        public IActionResult Edit(int id)
        {
            Category category = _db.Category.FirstOrDefault(c => c.Id == id);
            return View(category); 
        }

        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            _db.Update(category);
            _db.SaveChanges();
            return View(category);

        }


        #endregion

        #region Details
        public IActionResult Details()
        {
            return View();
        }


        #endregion





    }
}