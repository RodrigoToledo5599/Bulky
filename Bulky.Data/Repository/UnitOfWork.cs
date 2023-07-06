using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Data.RepositoryGet;
using BulkyBook.Data.RepositoryGet.IRepositoryGet;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.Data;

namespace BulkyBook.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepositoryGet ProductGet { get; }
        public IProductRepository Product { get; set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            ProductGet = new ProductRepositoryGet(_db);
            Product = new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
