using BulkyBook.Data.Repository.IRepository;
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

        public IActionResult Details(int id)
        {
            var produto = _db.Product.Get(c=> c.Id == id);
            return View(produto);
        }




		#endregion



	}
}

