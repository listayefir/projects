using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Logic
    {
        int size;
        bool[] arr;
        bool[] rule = new bool[8];
        static Random rand = new Random();
        public Logic(int size)
        {
            this.size = size;
            arr = new bool[size];
        }

        public void setRandom()
        {
            Random rand = new Random();
            for (int j = 0; j < size; j++)
            {
                arr[j] = rand.Next(0, 2) == 1;
            }
        }

        public void setMiddleOne()
        {
            for (int j = 0; j < size; j++)
            {
                arr[j] = false;
            }
            arr[size / 2] = true;
        }

        public void setRule(int nr)
        {
            for (int i=0; i<8;i++)
            {
                this.rule[i] = (nr % 2 == 1);
                nr /= 2;
            }

        }

        public void nextGen()
        {
            bool [] next_arr = new bool[size];
            int j;
            for (j = 0; j < size; j++)
            {
                int cat = 4 * (arr[(j - 1+size)%size] ? 1 : 0) +
                    2 * (arr[j] ? 1 : 0) +
                    (arr[(j + 1)%size] ? 1 : 0);
                next_arr[j] = rule[cat];
            }
            for (j = 0; j < size; j++)
                arr[j] = next_arr[j];
        }

        public void Change()
        {
            int nr = rand.Next(0, size);
            arr[nr] = false;
        }

        public void changeRule()
        {
            int nr = rand.Next(0, 8);
            rule[nr] = !rule[nr];
        }
        public string Life()
        {
            StringBuilder sb = new StringBuilder(size);
            for (int j = 0; j < size; j++)            
                sb.Append (arr[j] ? "#" : ".");
                return sb.ToString();
            
        }
    }
}
