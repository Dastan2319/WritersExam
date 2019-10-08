using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public class BooksRepository : IRepository<Books>
    {
        private Model1 db;

        public BooksRepository(Model1 context)
        {
            this.db = context;
        }
        public void Create(Books item)
        {
            db.Books.Add(item);
        }

        public void Delete(int id)
        {
            Books answer= db.Books.Where(x => x.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.Books.Remove(answer);
            } 
        }

        public IEnumerable<Books> Find(Func<Books, bool> predicate)
        {
            return db.Books.Where(predicate).ToList();
        }

        public Books Get(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Books> GetAll()
        {
            return db.Books;
        }

        public void Update(Books item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
