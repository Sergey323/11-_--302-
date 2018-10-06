using _11Вариант.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Вариант
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите выражение для вычисления. Для выхода напишите exit");
                string s = Console.ReadLine();
                if (s == "exit")
                    return;
                var result = CalculateExpression.Calculate(s);
                if (result == null)
                    Console.WriteLine("Неправильный формат ввода");
                else
                    Console.WriteLine(result);
            }
        }
    }
}


    

