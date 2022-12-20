using Microsoft.EntityFrameworkCore;

namespace SerimTask2.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
    }
}
