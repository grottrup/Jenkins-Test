﻿using System;

namespace Calculator
{

    public class Calculator : ICalculator
    {
        public Calculator(){ }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Invert(double a)
        {
            return a * (-1);
        }
    }
}
