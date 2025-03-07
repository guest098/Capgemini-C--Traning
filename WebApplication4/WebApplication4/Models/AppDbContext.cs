
using Microsoft.EntityFrameworkCore;

namespace AuthUserService.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
