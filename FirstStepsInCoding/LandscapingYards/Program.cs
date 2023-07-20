using System.Xml.Schema;

namespace LandscapingYards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double totalPrice = (area * pricePerSquareMeter);
            double discount = totalPrice * 0.18;


            Console.WriteLine("The final price is: " + (totalPrice - discount )+ " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");

        }
    }
}