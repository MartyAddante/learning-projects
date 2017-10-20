using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCblockProblem
{
    class Blocks
    {
        public string sideOne;
        public string sideTwo;
        public int blockNumber;

        public Blocks(char one, char two, int iD)
        {
            sideOne = one.ToString();
            sideTwo = two.ToString();
            blockNumber = iD;
        }


    }
}
