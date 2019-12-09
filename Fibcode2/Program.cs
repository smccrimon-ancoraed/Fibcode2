using System;

namespace Fibcode2
{
    class Program
    {


   /*
         * Function:  int Fib(n)
         * Return nth terms of the Fibonacci series using a Looping method / iterative method
         * 
         * 
         */

        public int Fib(int num)
        {
            // Recursive method of calling itself
            // Call itself until it meets base initials as either  0 to 1 

            if (num == 0) { return 0; }
            else if (num == 1) { return 1; }
            else
            {
                return Fib(num - 1) + Fib(num - 2);
            }
                
        }



        static void Main(string[] args)
        {
            Program mynum = new Program();


            Console.WriteLine("Fibonacci numbers\n");
            Console.WriteLine("The number of rabbits paris at the end of n months");
            Console.WriteLine("\nIn this example we will use n=14\n");
            Console.WriteLine("Fib(14) = "+mynum.Fib(14)+"\n");
            Console.ReadKey();
        }
    }
}
    