namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  "The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            string archName = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int neededTime = 3 * project;
            
            Console.WriteLine($"The architect {archName} will need {neededTime} hours to complete {project} project/s.");
        }
    }
}