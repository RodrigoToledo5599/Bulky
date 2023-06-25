using BulkyWeb.Data;
using BulkyWeb.Models;
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








	}
}