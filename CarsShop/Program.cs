namespace CarsShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarsContext context= new CarsContext();

            var CarModel1 = new CarSale { 
                CarModel = "Dacia Duster", 
                Color="Blue", 
                Speed=200
            };
            context.Add(CarModel1);
            context.SaveChanges();

            //Example1<int> example = new Example1<int>();
            //example.Mat(1);
            //example.Matx(2);

            //Example2.Exam(2);//inverd
            //Example2.Exam1(5.3);

           
        }
    }
}