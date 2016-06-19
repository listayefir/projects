using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int fuckt(int n)
        {
            if (n == 1)
                return 1;
            return (fuckt(n - 1) * n);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fuckt(5));
            Console.ReadKey();

        }
    }
}
