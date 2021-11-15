using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathysBooks.DataAccess.Repository.IRepository
{
    interface IUnitofWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}
