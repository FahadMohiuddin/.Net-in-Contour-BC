using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.MyDbContext
{
    public class SchoolMS:DbContext
    {
        public SchoolMS(DbContextOptions<SchoolMS> contextOptions) : base(contextOptions) { }
        public DbSet<student> students { get; set; }
        public DbSet<address> addresses { get; set; }
    }
}
