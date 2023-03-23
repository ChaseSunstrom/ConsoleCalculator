using System.Data;

namespace ConsoleCalculator
{
    class Program
    {
        public static void Main(String[] args)
        {
            DataTable expression = new DataTable();
            string input = "";
            Console.WriteLine("Calculator for simple console calculations, enter 'break' to exit");
            while (input != "y")
            {
                try
                {
                    Console.WriteLine("Enter expression: ");
                    int answer = (int)expression.Compute(Console.ReadLine(), "");
                    Console.WriteLine("Answer: " + answer);
                    Console.WriteLine("Break? (enter 'y' to exit)");
                    input = Console.ReadLine().ToLower();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}