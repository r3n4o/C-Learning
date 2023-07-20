namespace CatsAndDogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catsFood = int.Parse(Console.ReadLine());
            double catsFoodPacketPrice = 2.50;
            double catFoodTotalPrice = catsFood * catsFoodPacketPrice;

            int dogFood = int.Parse(Console.ReadLine());
            int dogsFoodPacketPrice = 4;
            int dogFoodTotalPrice = dogFood * dogsFoodPacketPrice;

            Console.WriteLine($"{ catFoodTotalPrice + dogFoodTotalPrice} lv." );
        }
    }
}