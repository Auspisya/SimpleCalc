using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc.Models
{
    internal class Plus : Calculation
    {
        public override int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
