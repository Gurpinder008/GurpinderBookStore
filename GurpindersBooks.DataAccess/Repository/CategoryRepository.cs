using GurpindersBooks.DataAccess.Repository.IRepository;
using GurpindersBooks.Models;
using GurpinderBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace GurpindersBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOfDefault(s => s.id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }

    }
}
