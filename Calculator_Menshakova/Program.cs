using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Menshakova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            double result = calc.Calculate();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public abstract class Calculation
    {
        public abstract int Calculate(int a, int b);
    }

    public class Plus : Calculation
    {
        public override int Calculate(int a, int b)
        {
            return a + b;
        }
    }

    public class Minus : Calculation
    {
        public override int Calculate(int a, int b)
        {
            return a - b;
        }
    }
    public class Multiply : Calculation
    {
        public override int Calculate(int a, int b)
        {
            return a * b;
        }
    }
    public class Devide : Calculation
    {
        public override int Calculate(int a, int b)
        {
            return (a / b);
        }
    }

    public class Calculator
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
