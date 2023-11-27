using IMS.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IMS.WebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<Tools> Tools { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
    }
}
