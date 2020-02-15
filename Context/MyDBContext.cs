using ExtensionsStudy.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExtensionsStudy.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<Post> Posts { get; set; }
    }
}