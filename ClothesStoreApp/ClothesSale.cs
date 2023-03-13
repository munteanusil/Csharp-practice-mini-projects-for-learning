using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesStoreApp
{
    public class ClothesSale
    {
        private ClStoreContext _context;
        public ClothesSale(ClStoreContext context)
        {
            _context = context;
        }
        public void AddClothes()
        {
            Articole Articol1 = new Articole
            {
                ArticolName="tricou",
                ArticoleCost=15,
                ArticolType="Man"
                
            };
            Articole Articol2 = new Articole
            {
                ArticolName = "hanorac",
                ArticoleCost = 25,
                ArticolType = "Man"

            };
            Articole Articol3 = new Articole
            {
                ArticolName = "fusta",
                ArticoleCost = 35,
                ArticolType = "Woman"

            };
            Articole Articol4 = new Articole
            {
                ArticolName = "geaca",
                ArticoleCost = 40,
                ArticolType = "Woman"

            };
            _context.Add( Articol1 );
            _context.Add( Articol2 );
            _context.Add( Articol3 );
            _context.Add( Articol4 );
            _context.SaveChanges();

        }

       
    }
}
