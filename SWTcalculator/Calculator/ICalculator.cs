using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IClaculator
    {
        double add(double a, double b);
        double subtract(double a, double b);

        double multiply(double a, double b);
        double power(double a, double b);
    }
}
