using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Logic logic = new Logic(79);
            logic.setMiddleOne();
            int nr = 0;
            logic.setRule(999%123);
            while (true)
            {
                //Console.SetCursorPosition(0, 0);
                if (nr++ % 25 == 0)
                for (int k=0;k<10;k++)
                    logic.changeRule();
            Console.WriteLine(logic.Life());
            logic.nextGen();
                Thread.Sleep(100);
        }
            Console.WriteLine(logic.Life());
            Console.ReadKey();
        }
    }
}
