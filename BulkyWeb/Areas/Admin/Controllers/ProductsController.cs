﻿using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        public AppDbContext _context { get; set; }
        public IUnitOfWork _db { get; set; }
        public ProductsController(IUnitOfWork db, AppDbContext context)
        {
            _db = db;
            _context = context;
        }

        #region Index
        public IActionResult Index()
        {
            IEnumerable<SelectListItem> selectListItems = _context.Category.ToList()
                .Select(u => new SelectListItem { 
                    Value = u.Name,    
                    Text = u.Id.ToString()
                });
            ViewBag.categoria = selectListItems;

            var products = _context.Product.ToList();
            return View(products);
        }

        #endregion

        #region Details

        [HttpGet]
        public IActionResult Details(int id)
        {
			Product produto = _db.Product.Get(c => c.Id == id);
            if (produto == null)
                return NotFound();
            else
			    return View(produto);
		}


		#endregion

		#region Edit

        public IActionResult Edit (int id)
        {
			Product produto = _db.Product.Get(c => c.Id == id);
			return View(produto);
		}

        [HttpPost, ActionName("Edit")]
        public IActionResult Edit(Product produto) 
        {
            _db.Product.Update(produto);
            _db.Save();
            return View(produto);
        }

        #endregion

        #region Create

        public IActionResult Create()
        {
			IEnumerable<SelectListItem> CategoryList = _db.Category
				.GetAll().Select(u => new SelectListItem
				{
					Text = u.Name,
					Value = u.Id.ToString(),
				});
			ViewBag.CategoryList = CategoryList;
			return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod) 
        {
            if (ModelState.IsValid)
            {
                _db.Product.Add(prod);
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
            Product produto = _db.Product.Get(c => c.Id == id);
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var produto = _db.Product.Get(c => c.Id == id);
            _db.Product.Remove(produto);
            _db.Save();
            return RedirectToAction("Index");
        }

        #endregion




    }
}

