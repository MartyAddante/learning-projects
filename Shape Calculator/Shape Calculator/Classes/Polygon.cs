using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator.Classes
{
    class Polygon : IShapeDimensions
    {
        private int sides;
        private double apothem;
        private double theBase;
        private double theHeight;
        private double sidelength;

        public double TheBase
        {
            get { return this.theBase; }
        }
        public double TheHeight
        {
            get { return this.theHeight; }
        }

        public int Sides
        {
            get { return this.sides; }
        }
        public double Apothem
        {
            get { return this.apothem; }
        }

        public double CalculateArea(double apothem)
        {
            return this.theBase * this.theHeight * 0.5;
        }

        public double CalculaterPerimeter()
        {
            return this.sides * this.sidelength;
        }
    }
}
