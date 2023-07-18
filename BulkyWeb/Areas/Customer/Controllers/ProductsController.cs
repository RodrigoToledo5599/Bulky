using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Customer.Controllers
{
	[Area("Customer")]
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
			var products = _db.ProductGet.GetAll();
			return View(products);
		}
        #endregion

        #region Details
        public IActionResult Details(int? id)
        {
			Product product = _db.ProductGet.Get(c => c.Id == id);
			if (product == null)
				return NotFound();
			else
				return View(product);
        }

        #endregion



    }
}
