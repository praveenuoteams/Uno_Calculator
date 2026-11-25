using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Uno_Calculator
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Out put :"+Add(10,20));
            Console.WriteLine("Subtraction o/p: "+Subtraction(50 , 10));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
