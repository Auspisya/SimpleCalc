using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCalc.Models;

namespace TestCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                try
                {
                    var calc = new Calculator();
                    double result = calc.Calculate();
                    Console.WriteLine(result);
                    Console.ReadKey();
                    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (y/n)");
                    again = Convert.ToChar(Console.ReadLine());
                }
                catch { Console.WriteLine("Вы ввели неправильный тип данных!"); }
            }
        }
    }
}
