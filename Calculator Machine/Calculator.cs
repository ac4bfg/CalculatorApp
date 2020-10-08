using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMachine
{
    public class Calculator
    {
        public int Penambahan(int a, int b)
        {
            return a + b;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public int Perkalian(int a, int b)
        {
            return a * b;
        }

        public static int Pembagian(int a, int b)
        {
            return a / b;
        }

        public int Pangkat(int a, int b)
        {
            return(int)Math.Pow(a , b);
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
