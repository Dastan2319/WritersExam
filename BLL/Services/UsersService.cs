using BLL.Interface;
using DLL;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UsersService : IService<Users>
    {
        IUnitOfWork Database { get; set; }

        public UsersService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(Users orderDto)
        {
            Database.Users.Create(orderDto);
        }

        public void Dispose()
        {
            Dispose();
        }

        public Users Get(int? id)
        {
           
                return Database.Users.Get(id);
            
            
        }

        public IEnumerable<Users> GetAll()
        {
            return Database.Users.GetAll();
        }
    }
}
