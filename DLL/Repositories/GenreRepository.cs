using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    class GenreRepository : IRepository<Genre>
    {
        private Model1 db;

        public GenreRepository(Model1 context)
        {
            this.db = context;
        }
        public void Create(Genre item)
        {
            db.Genre.Add(item);
        }

        public void Delete(int id)
        {
            Genre answer = db.Genre.Where(x => x.id == id).FirstOrDefault();
            if (answer != null)
            {
                db.Genre.Remove(answer);
            }
        }

        public IEnumerable<Genre> Find(Func<Genre, bool> predicate)
        {
            return db.Genre.Where(predicate).ToList();
        }

        public Genre Get(int? id)
        {
            return db.Genre.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genre;
        }

        public void Update(Genre item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
