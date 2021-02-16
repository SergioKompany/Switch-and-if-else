using System;

namespace If_else_task_1__Buy_a_kitty__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Well, " + name + "! Do you want to buy a pink kitty?");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
            Console.WriteLine("Relax, " + name + ", it was just a joke!");
            }
            else
            {
            Console.WriteLine("Everyone says \"" + answer + "\", but, " + name + ", buy a pink kitty!");
            }
            Console.ReadLine();
        }
    }
}
