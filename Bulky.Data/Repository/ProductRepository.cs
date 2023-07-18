using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data.Data;

namespace BulkyBook.Data.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
    {
        public AppDbContext _db { get; set; }
        public ProductRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            _db.Product.Update(product);
        }

	}
}
