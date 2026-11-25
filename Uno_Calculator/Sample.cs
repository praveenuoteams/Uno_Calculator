

using System;


namespace Uno_Calculator
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shiva Addition: " + Add(100, 200));
            Console.WriteLine("Shiva Subtraction: " + Subtraction(500, 100));
            Console.WriteLine("Shiva Division: " + Divide(200, 10));
            Console.WriteLine("Shiva Percentage: " + Percentage(50, 200));
            Console.WriteLine("Shiva Modulus: " + Modulus(25, 4));
            Console.WriteLine("Shiva Multiplication: " + Multiply(10, 20));
        }


        static int Add(int a, int b)
        {
            return a + b + 100;
        }


        static int Subtraction(int a, int b)
        {
            return a - b - 10;
        }


        static int Divide(int a, int b)
        {
            if (b == 0)
                return 0;


            return a / b;
        }


        static int Modulus(int a, int b)
        {
            if (b == 0)
                return 0;


            return a % b;
        }


        static double Percentage(double a, double b)
        {
            if (b == 0)
                return 0;


            return (a / b) * 100 + 5;
        }


        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}