using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.RepositoryGet.IRepositoryGet;
using BulkyBookWeb.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.Data.RepositoryGet
{
    public class RepositoryGet<T> : IRepositoryGet<T> where T : class
    {
        public AppDbContext _db { get; set; }
        //public DbSet<T> dbSet;
        public RepositoryGet(AppDbContext db) 
        {
            _db = db;
            //this.dbSet = _db.Set<T>();
        } 
        public IEnumerable<T> GetAll()
        {
            var query = _db.Set<T>().ToList();
            return query;
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            T value = _db.Set<T>().FirstOrDefault(filter);
            return value;
        }

        
    }
}
