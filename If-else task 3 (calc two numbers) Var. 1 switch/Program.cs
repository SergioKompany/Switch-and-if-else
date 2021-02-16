using System;

namespace If_else_task_3__calc_two_numbers__Var._1_switch
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
            switch (oper)
            {
                case "+":
                    int sum = first + second;
                    Console.WriteLine("Result is: " + sum);
                    break;
                case "-":
                    int difer = first - second;
                    Console.WriteLine("Result is: " + difer);
                    break;
                case "*":
                    int prod = first * second;
                    Console.WriteLine("Result is: " + prod);
                    break;
                case "/":
                    if (second == 0)
                    {
                        Console.WriteLine("It cannot be divided by zero. Be attentive!");
                    }
                    else
                    {
                        int part = first / second;
                        Console.WriteLine("Result is: " + part);
                    }
                    break;
                default:
                    Console.WriteLine("You have made a mistake. Choose correct operator!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
