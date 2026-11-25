using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace Uno_Calculator
{
    class Sample
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Out put :"+Add(10,20));
            Console.WriteLine("Subtraction o/p: "+Subtraction(50 , 10));


           
            Console.WriteLine("Out put :"+Divide(100, 20));

            Console.WriteLine("Out put  Shiva's :" + Add(30, 50));
            Console.WriteLine("Out put :" + Percentage(10, 20));
            Console.WriteLine("Out put of addition :"+Add(10,20));
            Console.WriteLine("Modulus :"+Modulus(12,5));


        }

        static int Add(int a, int b)
           
        {
            return a + b+100;
            
        }
        static int Divide(int a, int b) {
            return a / b;
        }
        static int Modulus(int c, int d)
        {
            return c % d;
        }

        static double Percentage(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return (a / b) * 100;

        }
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}

