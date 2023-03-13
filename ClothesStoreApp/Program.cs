namespace ClothesStoreApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ClStoreContext contexth= new ClStoreContext();
            ClothesSale Haine= new ClothesSale(contexth);
            Haine.AddClothes();
            
            

        }
    }
}