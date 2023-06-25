using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public AppDbContext _db { get;set; }
        public List<Category> categories { get; set; }


        public CategoryController(AppDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            categories = _db.Category.ToList();
            return View(categories);
        }
    

    
    
    
    
    
    
    
    
    
    
    
    
    }
}