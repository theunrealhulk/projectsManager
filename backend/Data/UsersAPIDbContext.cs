using Microsoft.EntityFrameworkCore;
using backend.Models;
namespace backend.Data
{
    public class UsersAPIDbContext:DbContext
    {
        public UsersAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
