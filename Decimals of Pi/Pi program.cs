using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nthNumber = 1000000000;
            //pi variable that will be returned and printed to console
            double pi = 0.0;
            
            //Use input variable to figure out length of series and determine the number of decimals
            for (int i = 0; i < nthNumber; i++)
            {
                
                if(i == 0 || i % 2 == 0)
                {
                    pi += (4.0 / (1.0 + (i * 2.0)));
                }
                else
                {
                    pi -= 4.0 / (1.0 + (i * 2.0));
                }
            }

            //pi calculation printed
            Console.WriteLine(pi);





        }
    }
}
