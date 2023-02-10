using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCalcOOP.Models;

namespace TestCalcOOP.Actions
{
    internal class Calculator
    {
        public float Calculate()
        {
            bool is_running = true;
            Console.WriteLine("Введите число:");
            float value = (int)Convert.ToDouble(Console.ReadLine());
            float total = value;
            while (is_running)
            {
                Console.WriteLine("Введите один из операторов +, -, *, /, = :");
                char opChar = Convert.ToChar(Console.ReadLine());
                if (opChar == '=')
                    break;

                Console.WriteLine("Введите число:");
                value = (int)Convert.ToDouble(Console.ReadLine());

                Calculation op;
                switch (opChar)
                {
                    case '-':
                        op = new Minus();
                        break;
                    case '+':
                        op = new Plus();
                        break;
                    case '*':
                        op = new Multiply();
                        break;
                    case '/':
                        op = new Devide();
                        break;
                    default: throw new NotSupportedException("Неверная операция!");
                }
                total = op.Calculate(value, total);
            }

            Console.WriteLine("Результат вычисления:");
            return total;
        }
    }
}
