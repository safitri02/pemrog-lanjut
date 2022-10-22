using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMachine
{
    public class Calculator
    {
        public int tambah (int a , int b)
        {
            return a + b;
        }
        public int kurang(int a, int b)
        {
            return a - b;
        }
        public int kali(int a, int b)
        {
            return a * b;
        }
        public static int bagi(int a, int b)
        {
            return a / b;
        }
        public int pangkat(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public static int modulo(int a, int b)
        {
            return a % b;

        }
    }
}
