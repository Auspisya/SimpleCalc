using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCalcOOP.Models;

namespace TestCalcOOP.Actions
{
    class Minus : Calculation
    {
        public override float Calculate(float value, float total)
        {
            return total -= value;
        }
    }
}
