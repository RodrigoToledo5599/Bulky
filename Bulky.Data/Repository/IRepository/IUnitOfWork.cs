using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Data.RepositoryGet.IRepositoryGet;

namespace BulkyBook.Data.Repository.IRepository
{
    public interface IUnitOfWork 
    {
        ICategoryRepository Category { get; }
        IProductRepositoryGet ProductGet {  get; }

        void Save();
    }
}
