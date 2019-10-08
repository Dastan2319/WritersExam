using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public  interface IService<T>where T: class
    {
        void Create(T orderDto);
        T Get(int? id);
        IEnumerable<T> GetAll();
        void Dispose();
    }
}
