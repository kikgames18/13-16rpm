using Microsoft.EntityFrameworkCore;
using _13_16.Models;

namespace _13_16.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<_13_16.Models.Task> Tasks { get; set; }
    }
}
