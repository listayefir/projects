using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
       

        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(fib(n));
            Console.ReadKey();
        }
        public static long fib(long n)
        {
            if (n <= 1)
                return 1;
            return (fib(n - 1) + fib(n));

        }
    }
}
    

