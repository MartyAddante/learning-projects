using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator.Classes
{
    public interface IShapeDimensions
    {
        int sides { get; }
        double CalculateArea();
        double CalculaterPerimeter();
    }
}
