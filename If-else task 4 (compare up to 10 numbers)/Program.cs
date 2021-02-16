using System;

namespace If_else_task_4__compare_up_to_10_numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter d");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter e");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter f");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter g");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter h");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter l");
            int l = int.Parse(Console.ReadLine());

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }
            if (max < e)
            {
                max = e;
            }
            if (max < f)
            {
                max = f;
            }
            if (max < g)
            {
                max = g;
            }
            if (max < h)
            {
                max = h;
            }
            if (max < k)
            {
                max = k;
            }
            if (max < l)
            {
                max = l;
            }
            Console.WriteLine("Maximum is: " + max);
            Console.ReadLine();





        }
    }
}
