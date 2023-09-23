using System;


namespace ConsoleApp1
{
   class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main()
        {
            Console.WriteLine("please enter the provided number");
            int count=int.Parse(Console.ReadLine());
            fibonnaci(count - 2);
            Console.WriteLine();
        }

        private static void fibonnaci(int count)
        {
            if (count > 0)
            {
                p3 = p1 + p2;
                Console.WriteLine(" " + p3);
                p1 = p2;
                p2 = p3;
                fibonnaci(count - 1);
                Console.ReadKey();            }
        }
        
        }
    
}
