
using Bulky.Data.Repository.IRepository;
using Bulky.Models;
using BulkyWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public ICategoryRepository _db { get;set; }
        public IEnumerable<Category> categories { get; set; }
        //public Category Category { get; set; }

        public CategoryController(ICategoryRepository db) 
        {
            _db = db;
        }
        #region Index
        public IActionResult Index()
        {
            categories = _db.GetAll();
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
                _db.Add(category);
                _db.Save();
                
                return RedirectToAction("Index");
            }
            else
                return View(); 
        }

		#endregion

		#region Delete

        public IActionResult Delete(int id) 
        {
            var Category = _db.Get(c => c.Id == id);
            return View(Category);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePost(int id) 
        {
            var Category = _db.Get(c => c.Id == id);
            _db.Remove(Category);
            _db.Save();
            return RedirectToAction("Index");
        }

		#endregion

		#region Edit
        public IActionResult Edit(int id)
        {
            Category category = _db.Get(c => c.Id == id);
            return View(category); 
        }

        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            _db.Update(category);
            _db.Save();
            return View(category);

        }


        #endregion

        #region Details
        //dps eu faço essa bagaça aq e.e
        public IActionResult Details()
        {
            return View();
        }


        #endregion





    }
}