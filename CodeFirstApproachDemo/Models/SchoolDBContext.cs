using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachDemo.Models
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext()
        {
            
        }
        public SchoolDBContext(DbContextOptions options):base(options) { 
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CDACLAB-127;Initial Catalog=SchoolDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
