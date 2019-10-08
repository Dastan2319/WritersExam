namespace DLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public Model1(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<comments> comments { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>()
                .HasMany(e => e.comments)
                .WithRequired(e => e.Books)
                .HasForeignKey(e => e.bookID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.comments)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
