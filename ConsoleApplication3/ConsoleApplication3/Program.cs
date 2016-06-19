using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string smile =":-";
            char[] brack = new char[num]; 
            for (int i =0; i< num; i++)
            {
                brack[i]=')';
            }
            string brackets = new string(brack);
            Console.WriteLine(smile+brackets);
            Console.ReadKey();
        }
    }
}
