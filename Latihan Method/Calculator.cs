using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Method
{
    public class Calculator
    {
        public int Penjumlah(int a, int b)
        {
            return a + b;
        }

        public int Penjumlah(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        public static int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
