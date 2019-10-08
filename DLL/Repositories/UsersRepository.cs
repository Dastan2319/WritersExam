using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public class UsersRepository:IRepository<Users>
    {
        private Model1 db;

        public UsersRepository(Model1 context)
        {
            this.db = context;
        }
        public void Create(Users item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            Users answer = db.Users.Where(x => x.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.Users.Remove(answer);
            }
        }

        public IEnumerable<Users> Find(Func<Users, bool> predicate)
        {
            return db.Users.Where(predicate).ToList();
        }

        public Users Get(int? id)
        {
            return db.Users.Find(id);
        }

        

        public IEnumerable<Users> GetAll()
        {
            return db.Users;
        }

        public void Update(Users item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
