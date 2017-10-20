using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator.Classes
{
    class Square : IShapeDimensions
    {
        
        private double sidelength;
        int sides = 4;

        public int Sides
        {
            get { return this.sides; }
        }          

        public double CalculateArea()
        {
            return this.sides * this.sides;
        }

        public double CalculaterPerimeter()
        {
            return this.sides * sides;
        }
    }
}
