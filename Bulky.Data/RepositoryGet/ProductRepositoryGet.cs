using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBookWeb.Data.Data;
using BulkyBook.Data.RepositoryGet.IRepositoryGet;
using BulkyBook.Models.Models;

namespace BulkyBook.Data.RepositoryGet
{
    public class ProductRepositoryGet : RepositoryGet<Product>, IProductRepositoryGet
    {
        public AppDbContext _db;
        public ProductRepositoryGet(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
