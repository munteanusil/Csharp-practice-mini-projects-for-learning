using Microsoft.EntityFrameworkCore;


namespace PlayListMusic
{
    public class SongsDbContext : DbContext
    {
        public SongsDbContext(DbContextOptions<SongsDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=PlayListMusic;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=True;");
        }

        public DbSet<Song> Songs { get; set;}
    }
}
