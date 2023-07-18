using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [BindProperties]
    public class ProductsController : Controller
    {
        public IUnitOfWork _db { get; set; }
        public ProductsController(IUnitOfWork db)
        {
            _db = db;
        }

        #region Index
        public IActionResult Index()
        {
            var products = _db.Product.GetAll();
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
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod) 
        {
            if (ModelState.IsValid)
            {
                _db.Product.Add(prod);
                _db.Save();
                return View(prod);
            }
            else
                return View();
        }

        #endregion

        #region Delete

        public IActionResult Delete(int id)
        {
            var prod = _db.Product.Get(c => c.Id == id);
            return View(prod);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var prod = _db.Product.Get(c => c.Id == id);
            _db.Product.Remove(prod);
            _db.Save();
            return RedirectToAction("Index");
        }

        #endregion




    }
}

