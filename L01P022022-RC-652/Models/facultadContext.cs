using Microsoft.EntityFrameworkCore;
namespace L01P022022_RC_652.Models
{
    public class facultadContext : DbContext
    {
        public facultadContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
    }
}
