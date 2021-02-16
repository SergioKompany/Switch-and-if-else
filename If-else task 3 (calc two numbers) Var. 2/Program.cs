using System;

namespace If_else_task_3__calc_two_numbers__Var._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2d number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operator (+ - * /):");
            string oper = Console.ReadLine();
            if (oper == "+")
            {
                int sum = first + second;
                Console.WriteLine("Result is: " + sum);
            }
            else if (oper == "-")
            {
                int difer = first - second;
                Console.WriteLine("Result is: " + difer);
            }
            else if (oper == "*")
            {
                int prod = first * second;
                Console.WriteLine("Result is: " + prod);
            }
            else if (oper == "/")
            {
                if (second == 0)
                {
                    Console.WriteLine("It cannot be divided by zero. Be attentive!");
                }
                else
                {
                    int part = first / second;
                    Console.WriteLine("Result is: " + part);
                }
            }
            else
            {
                Console.WriteLine("You have made a mistake. Choose correct operator!");
            }
            Console.ReadLine();
        }
    }
}
