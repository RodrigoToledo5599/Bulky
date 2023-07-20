using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.Repository.IRepository;
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public AppDbContext _db;
        public DbSet<T> dbSet;
        public Repository(AppDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }


        public void Add(T entity)
        {
            dbSet.Add(entity);
            _db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            T value = _db.Set<T>().FirstOrDefault(filter);
            return value;

        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
