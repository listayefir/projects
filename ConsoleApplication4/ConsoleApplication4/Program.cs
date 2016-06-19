using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3 }));
            Console.WriteLine(MaxIndex(new double[] { }));
            Console.WriteLine(MaxIndex(new double[] { 1 }));
            Console.WriteLine(MaxIndex(new double[] { 0, 100, 1, 2, 100 }));
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3, 100, 4, 5, 6 }));
            Console.WriteLine(MaxIndex(new double[] { 100, 100, 100, 100 }));
            //Console.WriteLine(MaxIndex(CreateSecretBigArray1()));
            //Console.WriteLine(MaxIndex(CreateSecretBigArray2()));

            Console.ReadKey();
        }
        public static int MaxIndex(double[] array)
        {
            
           // if (array.Length == 0)
               // return -1;
            //else
            //{

                double max = 0;
                for (int i = 0; i < array.Length; i++)
                {
                        if (array[i] > max)
                        max = array[i];
                }
                return Array.IndexOf(array, max);
            //}
        }


    }
    }

