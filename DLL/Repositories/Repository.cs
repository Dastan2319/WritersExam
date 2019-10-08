using DLL;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repositories
{
    public class Repository : IUnitOfWork
    {
        private Model1 db;
        private BooksRepository booksRepository;
        private UsersRepository usersRepository;
        private commentsRepository commentsRepository;
        private GenreRepository genreRepository;

        public Repository(string connectionString)
        {
            db = new Model1(connectionString);
        }

        public IRepository<Books> Books
        {
            get
            {
                if (booksRepository == null)
                    booksRepository = new BooksRepository(db);
                return booksRepository;
            }
        }

        public IRepository<comments> comments
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Genre> Genre
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Users> Users
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
