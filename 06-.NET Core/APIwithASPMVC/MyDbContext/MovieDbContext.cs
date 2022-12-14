using APIwithASPMVC.Model;
using Microsoft.EntityFrameworkCore;

namespace APIwithASPMVC.MyDbContext
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<MyMovie> movie { get; set; }
    }
}
