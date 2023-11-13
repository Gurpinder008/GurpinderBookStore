using System;
using System.Collections.Generic;
using System.Text;

namespace GurpindersBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
        object save { get; }

        void Save();
    }
}
