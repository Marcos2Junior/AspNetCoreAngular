using JujubaControle_API.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace JujubaControle_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<User> User { get; set; } 
        public DbSet<Address> Address { get; set; }
        public DbSet<ExceptionDb> ExceptionDb { get; set; }
        public DbSet<ImageUser> ImageUser { get; set; }
    }
}