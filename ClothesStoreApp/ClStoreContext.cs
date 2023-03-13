using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreApp
{
    public class ClStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=DESKTOP-CT3VKRI\\SQLEXPRESS; Database=ClothesStoreApp;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=True;");
        public DbSet <Articole> Clothes { get; set; }
    }
}
