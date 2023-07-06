using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.Data;

namespace BulkyBook.Data.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _db;

        public CategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Category.Update(obj);
        }
    }
}
