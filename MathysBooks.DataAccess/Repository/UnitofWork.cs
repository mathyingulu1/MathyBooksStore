using MathysBooks.DataAccess.Repository.IRepository;
using MathyBooksStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathysBooks.DataAccess.Repository
{
    public class UnitofWork
    {
        private readonly ApplicationDbContext_db;

            public UnitofWork(ApplicationDbContext_Db)
        {
            _db = Db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; set; }

        public ISP_Call SP_Call { get; set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save();
        {
             _db.SaveChanges();
    }
}
