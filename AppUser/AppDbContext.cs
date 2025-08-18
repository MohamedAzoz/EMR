using UerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace UerApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserAPI> Users { get; set; }

        public AppDbContext():base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ABC;Initial Catalog=UnitTestDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
        
    }
}
