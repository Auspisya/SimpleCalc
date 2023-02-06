using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc.Models
{
    internal class Calculator
    {
        public int Calculate()
        {
            Console.WriteLine("Введите первое число:");
            int a = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            char opChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = (int)Convert.ToDouble(Console.ReadLine());

            Calculation op;
            switch (opChar)
            {
                case '+': op = new Plus(); break;
                case '-': op = new Minus(); break;
                case '*': op = new Multiply(); break;
                case '/': op = new Devide(); break;
                default: throw new NotSupportedException("Неверная операция!");
            }
            Console.WriteLine("Результат вычисления:");
            return op.Calculate(a, b);
        }
    }
}
