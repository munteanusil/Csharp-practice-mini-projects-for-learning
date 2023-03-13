using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreApp
{
    
    public class Articole
    {
        [Key]
        public int ArticolId { get; set; }
        public string ArticolName { get; set; }
        public string ArticolType { get; set;}
        public double ArticoleCost { get; set; }
    
    }
}
