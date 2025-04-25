using Microsoft.EntityFrameworkCore;

namespace MusicWebApp.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
