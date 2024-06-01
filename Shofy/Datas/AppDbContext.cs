using Microsoft.EntityFrameworkCore;
using Shofy.Models;


namespace Shofy.Datas

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

    }
}
