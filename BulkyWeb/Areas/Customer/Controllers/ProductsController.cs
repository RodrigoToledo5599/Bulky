using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Customer.Controllers
{
	[Area("Customer")]
	[BindProperties]

	public class ProductsController : Controller
	{
		[BindProperty]
		public IUnitOfWork _db { get; set; }
		//public Product product { get; set; }

		//public IEnumerable<Product> products { get; set; }

		public ProductsController(IUnitOfWork db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			var products = _db.ProductGet.GetAll();
			return View(products);
		}

        #region Details
        public IActionResult Details(int? id)
        {
            Product product = _db.Product.Get(c => c.Id == id);
			if (product == null)
				return NotFound();

            return View(product);
        }

        #endregion



    }
}
