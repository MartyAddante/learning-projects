using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1000)
            {
                Random number = new Random();
                int green = number.Next(0, 19);
                Console.WriteLine(green);
                i++;

                if (green == 0)
                {
                    break;
                }

            }
            


        }
    }
}
