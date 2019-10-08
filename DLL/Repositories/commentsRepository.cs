using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public class commentsRepository:IRepository<comments>
    {
        private Model1 db;

        public commentsRepository(Model1 context)
        {
            this.db = context;
        }
        public void Create(comments item)
        {
            db.comments.Add(item);
        }

        public void Delete(int id)
        {
            comments answer = db.comments.Where(x => x.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.comments.Remove(answer);
            }
        }

        public IEnumerable<comments> Find(Func<comments, bool> predicate)
        {
            return db.comments.Where(predicate).ToList();
        }

        public comments Get(int id)
        {
            return db.comments.Find(id);
        }

        public IEnumerable<comments> GetAll()
        {
            return db.comments;
        }

        public void Update(comments item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
