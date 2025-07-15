using Microsoft.EntityFrameworkCore;
using BakeryRose.Models;

namespace BakeryRose.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { }

        public DbSet<Proveedores> Proveedores { get; set; }
    }
}


