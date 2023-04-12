
using System;
namespace FibonacciNumbers
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void Main(string[] args)
        {
            int printcount = 0;
            int fibcount = 2;
            int n;

            Console.WriteLine("Luke Bacopoulos");

            while (printcount < 10)
            {
                n = Fibonacci(fibcount);
                if (n >= 100)
                {
                    Console.WriteLine("{0} ", n);
                    printcount++;
                }
                fibcount++;
            }

        }



    }
}

