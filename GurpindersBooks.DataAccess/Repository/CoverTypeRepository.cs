using GurpindersBooks.DataAccess.Repository.IRepository;
using GurpindersBooks.Models;
using GurpinderBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GurpindersBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<Category>, ICategoryRepository
    {

        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                // _db.SaveChanges();
            }
        }

    }
}
    

