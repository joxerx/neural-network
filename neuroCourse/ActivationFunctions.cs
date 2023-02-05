using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuroCourse
{
    internal class ActivationFunctions
    {
        static public double Treshold(double value)
        {
            if (value < 0)
                return 0;
            else
                return 1;
        }
        static public double Signature(double value)
        {
            if (value > 0)
                return 1;
            else
                return -1;
        }
        static public double Sigmoid(double value)
        {
            return 1 / (1 + Math.Exp(-value));
        }
        static public double HalfLinear(double value)
        {
            if (value > 0)
                return value;
            else
                return 0;
        }
    }
}
