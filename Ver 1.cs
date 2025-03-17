using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPPver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой консольный калькулятор (версия 1)");

            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ошибка: Некорректный ввод числа!");
                return;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ошибка: Некорректный ввод числа!");
                return;
            }

            Console.Write("Выберите операцию (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Перенос строки после ввода операции

            double result;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль!");
                        return; // Завершаем программу
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ошибка: Неверная операция!");
                    return; // Завершаем программу
            }

            Console.WriteLine("Результат: " + result);
           
        }
    }
}
