using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class ShowDbContext : DbContext
    {
        public ShowDbContext (DbContextOptions<ShowDbContext> options)
            : base(options)
        {
        }
        public DbSet<Character> Characters {get; set;}
        public DbSet<Show> Shows {get; set;}

    }
}