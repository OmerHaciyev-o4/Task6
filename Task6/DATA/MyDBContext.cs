using Microsoft.EntityFrameworkCore;
using Task6.Entities;

namespace Task6.DATA
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }
        public DbSet<Breakfast> Breakfasts { get; set; }
    }
}