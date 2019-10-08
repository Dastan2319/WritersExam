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
                if (commentsRepository == null)
                    commentsRepository = new commentsRepository(db);
                return commentsRepository;
            }
        }

        public IRepository<Genre> Genre
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(db);
                return genreRepository;
            }
        }

        public IRepository<Users> Users
        {
            get
            {
                if (usersRepository == null)
                    usersRepository = new UsersRepository(db);
                return usersRepository;
            }
        }

        public void Dispose()
        {
            Dispose();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
