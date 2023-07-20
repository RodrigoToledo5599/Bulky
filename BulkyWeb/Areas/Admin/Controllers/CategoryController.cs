
using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IUnitOfWork _db { get; set; }

        public CategoryController(IUnitOfWork db)
        {
            _db = db;
        }
        #region Index
        public IActionResult Index()
        {
            var categories = _db.Category.GetAll().ToList();
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
            if (ModelState.IsValid)
            {
                _db.Category.Add(category);
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
            var Category = _db.Category.Get(c => c.Id == id);
            return View(Category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var Category = _db.Category.Get(c => c.Id == id);
            _db.Category.Remove(Category);
            _db.Save();
            return RedirectToAction("Index");
        }

        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            Category category = _db.Category.Get(c => c.Id == id);
            return View(category);
        }
        [HttpPost,ActionName("Edit")]
        public IActionResult Edit(Category category)
        {
            _db.Category.Update(category);
            _db.Save();
            return View(category);

        }


        #endregion

        #region Details
        
        public IActionResult Details(int id)
        {
            Category category = _db.Category.Get(c => c.Id == id);
            return View(category);
        }


        #endregion

    }
}