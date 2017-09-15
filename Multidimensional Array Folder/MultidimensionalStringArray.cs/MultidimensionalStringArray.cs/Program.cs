using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalStringArray.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] twoDArray = new string[13, 13];
            string[] oneDimension = new string[] { " H ", " e ", " e ", " e ", " e ", " y ", "   ", " M ", " a ", " r ", " t ", " y ", " ! " };

            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(oneDimension[j]);
                    }
                    else if (i % 2 != 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("-");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("+");
                        }

                    }
                    else if (i % 2 == 0)
                    {
                        if (j % 2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("o");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("+");
                        }
                    }
                }
                Console.WriteLine();
            }


        }
    }
}



