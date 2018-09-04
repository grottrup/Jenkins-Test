﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        //setup
        private IClaculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        //Add ved hjælp af Test
        [Test]
        public void Add_Add5And5_Returns10()
        {
           Assert.That(_uut.add(5, 5), Is.EqualTo(10));
        }

        [Test]
        public void Add_AddMinus5And6_Returns2()
        {
         
            Assert.That(_uut.add(-5, 7), Is.EqualTo(2));
        }

        [Test]
        public void Add_AddMinus5AndMinus6_ReturnsMinus11()
        {
            
            Assert.That(_uut.add(-5, -6), Is.EqualTo(-11.0));
        }
        
        //Subtract ved hjælp af TestCase
        [TestCase(9,6,3, TestName = "Subtract 9-6 = 3")]
        [TestCase(-9, 6, -15, TestName = "Subtract -9-6 = -15")]
        [TestCase(-9, -6, -3, TestName = "Subtract -9-(-6) = -3")]
        public void SubtractTest(double a, double b, double c)
        {
            
            Assert.That(_uut.subtract(a, b), Is.EqualTo(c));
        }

        //Multiply
        [TestCase(9, 6, 54, TestName = "Multiply 9 * 6 = 54")]
        [TestCase(-9, 6, -54, TestName = "Multiply -9 * 6 = -54")]
        [TestCase(-9, -6, 54, TestName = "Multiply -9 * -6 = 54")]
        public void MultiplyTest(double a, double b, double c)
        {
            
            Assert.That(_uut.multiply(a, b), Is.EqualTo(c));
        }

        //Power
        [TestCase(5, 2, 25, TestName = "Power 5 ^ 2 = 25")]
        [TestCase(-7, 3, -343, TestName = "Power -5 ^ 2 = -25")]
        [TestCase(-2, -3, -0.125, TestName = "Power -2 ^ -3 = -0,125")]
        public void PowerTest(double a, double b, double c)
        {
            
            Assert.That(_uut.power(a, b), Is.EqualTo(c));
        }

    }
}
