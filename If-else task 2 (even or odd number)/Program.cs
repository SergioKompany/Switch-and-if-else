using System;

namespace If_else_task_2__even_or_odd_number_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be checked:");
            int number = int.Parse(Console.ReadLine());
            int result = (number % 2);
            if (result == 1)
            {
                Console.WriteLine("This mumber is odd");
            }
            else
            {
                Console.WriteLine("This mumber is even");
            }
            Console.ReadLine();
        }
    }
}
