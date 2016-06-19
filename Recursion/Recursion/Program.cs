using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            MakePermutations(new int[3], 0);
            Console.ReadKey();
        }

        static void MakePermutations(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                foreach (var e in permutation)
                    Console.Write(e + " ");
                Console.WriteLine();
                return;

            }
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                permutation[position] = i;
                MakePermutations(permutation, position + 1);
            }
        }
    }
}
