using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalc
{
    internal class OperacionesBasicas
    {
        private int num1 = 0;
        private int num2 = 0;
        private double res = 0.0;

        public double Suma(int num1, int num2)
        {
            res = num1 + num2;
            return res;
        }
    }
}
