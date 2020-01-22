using ContosoCrafts.WebSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContosoCrafts.WebSite.database
{
    public class ApplicationDbContext : DbContext
    {
     

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
            ) : base(options)
        {
        }

        public DbSet<People> Peoples { get; set; }

        /*public IConfiguration Configuration { get; }

        public DbSet<People> Peoples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;user=root;database=csharp;port=3306;password=123456");

        }*/
    }
}
