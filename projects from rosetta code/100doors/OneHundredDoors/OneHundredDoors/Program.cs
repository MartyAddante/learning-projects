using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHundredDoors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Door> oneHundred = new List<Door>();
            for(int i = 0, j = 1; i < 100; i++, j++)
            {
                oneHundred.Add(new Door());
                oneHundred[i].number = j;
            }

            for(int i = 0; i < oneHundred.Count(); i++)
            {
                for(int j = 1; j < oneHundred.Count(); j++)
                {
                    if (oneHundred[i].number % j == 0)
                    {
                        if (oneHundred[i].isOpen == true)
                        {
                            oneHundred[i].isOpen = false;
                        }
                        else
                        {
                            oneHundred[i].isOpen = true;
                        }

                    }
                }
                
            }            
            for(int i = 0; i < oneHundred.Count(); i++)
            {

                if(oneHundred[i].isOpen == true)
                {
                    Console.WriteLine($"Door {oneHundred[i].number}: {oneHundred[i].isOpen.ToString()}");
                }
            }
        }
    }
}
