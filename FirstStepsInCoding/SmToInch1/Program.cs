namespace SmToInch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inc;
            double cm = Convert.ToDouble(Console.ReadLine());
            inc = cm * 2.54;
            Console.WriteLine("{0} centimeters  : {1} inches", cm, inc);
            // Console.ReadKey();

        }
    }
}