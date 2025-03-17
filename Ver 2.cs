using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorAPP
{
    internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Квадратный корень");
            Console.WriteLine("6. Возведение в степень");
            Console.WriteLine("7. Выход");

            string choice = Console.ReadLine();

            double num1, num2, result; // Объявляем переменные здесь

            switch (choice)
            {
                case "1":
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    result = Add(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "2":
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    result = Subtract(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "3":
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    result = Multiply(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "4":
                    Console.Write("Введите первое число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    Console.Write("Введите второе число: ");
                    if (!double.TryParse(Console.ReadLine(), out num2)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль!");
                        break;
                    }
                    result = Divide(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "5":
                    Console.Write("Введите число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    if (num1 < 0)
                    {
                        Console.WriteLine("Ошибка: Квадратный корень из отрицательного числа!");
                        break;
                    }
                    result = SquareRoot(num1);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "6":
                    Console.Write("Введите число: ");
                    if (!double.TryParse(Console.ReadLine(), out num1)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    Console.Write("Введите степень: ");
                    if (!double.TryParse(Console.ReadLine(), out num2)) { Console.WriteLine("Ошибка ввода!"); continue; }
                    result = Power(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    break;

                case "7":
                    Console.WriteLine("До свидания!");
                    return;

                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите операцию из списка.");
                    break;
            }
        }
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        return x / y;
    }

    static double SquareRoot(double x)
    {
        return Math.Sqrt(x);
    }

    static double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }
}
}