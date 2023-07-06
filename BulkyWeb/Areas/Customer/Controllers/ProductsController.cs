﻿using BulkyBook.Data.Repository.IRepository;
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


		



	}
}