using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Books> Books { get; }
        IRepository<Genre> Genre { get; }
        IRepository<Users> Users { get; }
        IRepository<comments> comments { get; }
        void Save();
    }
}
