using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}