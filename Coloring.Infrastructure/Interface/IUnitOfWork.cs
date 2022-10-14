using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coloring.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
