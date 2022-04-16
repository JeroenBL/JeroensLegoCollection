using BlazingLego.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingLego.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LegoSet> LegoSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=lego.db");
        }
    }
}
