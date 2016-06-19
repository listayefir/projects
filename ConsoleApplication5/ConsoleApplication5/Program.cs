using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static void Main()
        {
            //var dictionary = new Dictionary<char, Action>();
            //for (char c = 'A'; c < 'Z'; c++)
            //    dictionary.Add(c, () => Console.Write(c));

            //dictionary['X']();

            var list = new List<int>();
            list.Add(2);
            var a = list[0];
            Console.WriteLine(a);

            Console.ReadKey();
        }


    }
}
