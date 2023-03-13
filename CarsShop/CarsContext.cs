using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop
{
    public class CarsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CT3VKRI\\SQLEXPRESS; Database=CarsShop;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=True;");

        }

        public DbSet<CarSale> CarSales { get; set; }
    }
}
