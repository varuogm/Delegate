using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Program2
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Minus(int x, int y)
        {
            return x - y;
        }

        // define a delegate
        public delegate int TwoInputwalaKaamKarunga(int num1, int num2);

        static void Main()
        {
            // create an instance of delegate by passing method name 
            TwoInputwalaKaamKarunga aajChalSumKarde = new TwoInputwalaKaamKarunga(Sum);
            TwoInputwalaKaamKarunga aajChalMinusKarde = new TwoInputwalaKaamKarunga(Minus);

            Console.WriteLine(aajChalSumKarde(5, 6));
            Console.WriteLine(aajChalMinusKarde(5, 6));

        }
    }
}

