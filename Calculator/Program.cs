using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            try
            {
                Numbers();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Console.WriteLine("Снова? Y/N Да или Нет");

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\n");
                Numbers();
            }
            else
            {
                Environment.Exit(0);
            }
            

        }
        public static void Numbers()
        {
            Console.WriteLine("Введите первое число:");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите действие:");
            char action = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double number2 = double.Parse(Console.ReadLine());
            double result = 0;
            switch (action)
            {
                case '+':
                    result = number + number2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '-':
                    result = number - number2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '*':
                    result = number * number2;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number / number2;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    }
                    else
                    {
                        result = 0;
                        break;
                    }
                default:
                    Console.WriteLine("Неизвестное действие");
                    break;

            }
            
        }
    }
}
