using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator _Cal = new Calculator();

            Console.WriteLine("Add: {0}, subtract: {1}, multiply: {2}, power: {3}\n", _Cal.add(5, 5),
                _Cal.subtract(15, 10), _Cal.multiply(10, 10), _Cal.power(5, 3));
        }
    }
}
