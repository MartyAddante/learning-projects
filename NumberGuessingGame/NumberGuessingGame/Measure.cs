using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    public class Measure
    {
        public string HowClose(int guess, int actualNumber)
        {
            int posNeg = guess - actualNumber;
            double distance = Math.Abs(guess - actualNumber);
            double percent = (distance / (double)actualNumber) * 100;
            percent = Math.Round(percent);
            string hiOrLow = "";

            if (posNeg < 0)
            {
                hiOrLow = "lower";
            }
            else
            {
                hiOrLow = "higher";
            }

            if ((percent >= 250 && percent < 500) || (percent <= 50 && percent > 20))
            {
                hiOrLow = "much " + hiOrLow;
            }
            else if (percent >= 500 || percent <= 20)
            {
                hiOrLow = "WAAAY " + hiOrLow;
            }

            return hiOrLow;
        }


    }
}
