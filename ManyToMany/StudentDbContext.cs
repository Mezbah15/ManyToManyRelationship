using Microsoft.EntityFrameworkCore;

namespace ManyToMany
{
    public class StudentDbContext : DbContext
    {
        private readonly string _connection;
        public StudentDbContext()
        {
             _connection = "Server=MEZBAH\\SQLEXPRESS;Database=StudentData;Trusted_Connection=True; TrustServerCertificate=True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
