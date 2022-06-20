using Microsoft.EntityFrameworkCore;
using System;

namespace WPFSigninup.Models
{
    public class UsersDBContext: DbContext
    {
        public UsersDBContext() { }
        public UsersDBContext(DbContextOptions<UsersDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EFLibrary;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Identity = "AD215478",
                    FirstName = "Younes",
                    LastName = "ERRAJI",
                    Username = "younes-erraji",
                    Email = "younes-erraji@mail.com",
                    Password = "123456",
                    DateOfBirth = DateTime.Parse("14/07/2000"),
                }
            );
        }
    }
}
