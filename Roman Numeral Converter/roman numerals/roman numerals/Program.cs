using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.WriteLine("Input a number");
            string decimalInput = Console.ReadLine();
            //input conversion
            int numsRemainder = int.Parse(decimalInput);
            
            
            //decimal to roman numeral code

            //Number of 1000's
            int romanM = numsRemainder / 1000;

            //test for 900
            int romanNumeral_900   = numsRemainder % 1000;
            int romanCM            = romanNumeral_900 / 900;

            //test for 500
            int romanNumeral_500   = romanNumeral_900 % 900;
            int romanD             = romanNumeral_500 / 500;

            //test for 400
            int romanNumeral_400   = romanNumeral_500 % 500;
            int romanCD            = romanNumeral_400 / 400;

            //test for 100
            int romanNumeral_100   = romanNumeral_400 % 400;
            int romanC             = romanNumeral_100 / 100;

            //test for 90
            int romanNumeral_90    = romanNumeral_100 % 100;
            int romanXC            = romanNumeral_90 / 90;

            //test for 50
            int romanNumeral_50    = romanNumeral_90 % 90;
            int romanL             = romanNumeral_50 / 50;

            //test for 40
            int romanNumeral_40    = romanNumeral_50 % 50;
            int romanXL            = romanNumeral_40 / 40;

            //test for 10
            int romanNumeral_10    = romanNumeral_40 % 40;
            int romanX             = romanNumeral_10 / 10;

            //get final numeral
            int romanNumeralFinal  = romanNumeral_10 % 10;
            string[] romanLastDigit = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };


            int thousandsLoop = 0;
            int hundredsLoop = 0;
            int tensLoop = 0;
            //loop through thousands
            while(thousandsLoop < romanM)
            {
                Console.Write("M");
                thousandsLoop++;
            }
            if(romanCM == 1)
            {
                Console.Write("CM");
            }
            if (romanD == 1)
            {
                Console.Write("D");
            }
            if (romanCD == 1)
            {
                Console.Write("CD");
            }

            //loop through hundreds
            while (hundredsLoop < romanC)
            {
                Console.Write("C");
                hundredsLoop++;
            }
            if (romanXC == 1)
            {
                Console.Write("XC");
            }
            if (romanL == 1)
            {
                Console.Write("L");
            }
            if (romanXL == 1)
            {
                Console.Write("XL");
            }

            //loop through tens
            while(tensLoop < romanX)
            {
                Console.Write("X");
                tensLoop++;
            }
            if (romanNumeralFinal > 0)
            {
                Console.Write(romanLastDigit[romanNumeralFinal - 1]);
            }
            Console.WriteLine("\n\n");
        }
    }
}
