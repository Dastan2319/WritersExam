using DLL.Entity;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public class LoginRepository : IRepository<Login>
    {
        private Model1 db;

        public LoginRepository(Model1 context)
        {
            this.db = context;
        }
        public void Create(Login item)
        {
            db.Login.Add(item);
        }

        public void Delete(int id)
        {
            Login answer = db.Login.Where(x => x.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.Login.Remove(answer);
            }
        }

        public IEnumerable<Login> Find(Func<Login, bool> predicate)
        {
            return db.Login.Where(predicate).ToList();
        }

        public Login Get(int? id)
        {
            return db.Login.Find(id);
        }

        public IEnumerable<Login> GetAll()
        {
            return db.Login;
        }

        public void Update(Login item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
