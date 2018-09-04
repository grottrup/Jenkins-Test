using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Power(double a, double b);
        double Divide(double a, double b);
        double Invert(double a);
    }
}
