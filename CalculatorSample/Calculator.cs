using System;

namespace CalculatorSample
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }

        public int Substract(int a, int b)
        {
            checked
            {
                return a - b;
            }
        }

        public int Multiply(int a, int b)
        {
            checked
            {
                return a * b;
            }
        }

        public double Divide(int a, int b)
        {
            checked
            {
                if(b==0)
                    throw new DivideByZeroException();
                var result = (double) a / b;
                return result;
            }
        }
    }
}
