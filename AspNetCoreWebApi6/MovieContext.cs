using AspNetCoreWebApi6.Models;
using Microsoft.EntityFrameworkCore;


namespace AspNetCoreWebApi6
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options) 
        { 
        }
        DbSet<Movie> Movies { get; set; } = null;
    }
}
