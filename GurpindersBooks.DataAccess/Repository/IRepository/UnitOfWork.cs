﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GurpindersBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}