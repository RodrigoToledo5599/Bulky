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
        //public Product product { get; set; }

        //public IEnumerable<Product> products { get; set; }

        public ProductsController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var products = _db.Product.GetAll();
            return View(products);
        }

		#region Details

		[HttpPost, ActionName("Details")]
		public IActionResult Details(int id)
        {
			Product produto = _db.Product.Get(c => c.Id == id);
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

	}
}

