using Microsoft.EntityFrameworkCore;
using Calculater.Models;
namespace Calculater.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Calculation> Calculations { get; set; }

    }
}
