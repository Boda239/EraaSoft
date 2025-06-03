using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_One_Eraa
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double tax = 6.6;
            decimal priceLarge = 35;
            decimal priceSmall = 25;
            int Nlarge ;
            int Nsmall;
            double cost;
            double totalcost;
            Console.WriteLine("\t \t \t \t Welcome in Islam's Carpet Cleaning Service");
            Console.WriteLine("\t \t \t \t \t -______________________-");
            Console.WriteLine($"Enter Number of Large carpets:");
            Nlarge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Small carpets:");
            Nsmall=Convert.ToInt32 (Console.ReadLine());

            cost = Nlarge * (int)priceLarge + (Nsmall * (int)priceSmall );
            totalcost = cost + tax;
           
            Console.WriteLine($"Cost of Service: {cost:c}");
            Console.WriteLine($"Total Cost whith Tax: {totalcost:c}");

            Console.ReadLine();
        }
    }
}
