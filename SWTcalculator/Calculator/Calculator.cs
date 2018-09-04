using System;

namespace Calculator
{

    public class Calculator : IClaculator
    {
        public Calculator(){ }
        public double add(double a, double b)
        {
            return a + b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double power(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
