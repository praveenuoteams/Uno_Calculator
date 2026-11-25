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
            Console.WriteLine("Out put :"+Divide(100, 20));
        }

        static int Add(int a, int b)
           
        {
            return a + b;
            
        }
        static int Divide(int a, int b) {
            return a / b;
        }
    }
}
