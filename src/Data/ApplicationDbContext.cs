using BlazingLego.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingLego.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LegoSet> LegoSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var conn = $@"Data Source={baseDir}\\lego.db";
            optionsBuilder.UseSqlite(conn);
        }
    }
}
