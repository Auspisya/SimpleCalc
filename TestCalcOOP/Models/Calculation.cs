using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcOOP.Models
{
    public abstract class Calculation
    {
        public abstract float Calculate(float value, float total);
    }
}
