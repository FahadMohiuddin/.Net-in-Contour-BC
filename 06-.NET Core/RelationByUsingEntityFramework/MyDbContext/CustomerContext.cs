using Microsoft.EntityFrameworkCore;
using RelationByUsingEntityFramework.Models;


namespace RelationByUsingEntityFramework.MyDbContext
{
    public class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> contextOptions) : base(contextOptions) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> addresses { get; set; }

    }
}
