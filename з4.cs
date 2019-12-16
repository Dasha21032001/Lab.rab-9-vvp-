using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число в диапазоне от 100 до 999 ");
            N = Convert.ToInt32(Console.ReadLine());//вывод числа
            int a = N / 100;//первая цифра числа(сотни)
            int b = (N % 100) / 10;//вторая цифра числа(десятки)
            int c = (N % 100) % 10;//третья цифра числа( единицы)
            
                {
                    if (a == 1) { Console.WriteLine("сто"); }
                    if (a == 2) { Console.WriteLine("двести"); }
                    if (a == 3) { Console.WriteLine("триста"); }
                    if (a == 4) { Console.WriteLine("четыреста"); }
                    if (a == 5) { Console.WriteLine("пятьсот"); }
                    if (a == 6) { Console.WriteLine("шестьсот"); }
                    if (a == 7) { Console.WriteLine("седьсот"); }
                    if (a == 8) { Console.WriteLine("восемьсот"); }
                    if (a == 9) { Console.WriteLine("девятьсот"); }
                }


                if (((N % 100) >= 10) && ((N % 100) <= 19))
                {
                    if ((N % 100) == 1) { Console.WriteLine("одиннадцать"); }
                    if (a == 2) { Console.WriteLine("двенадцать"); }
                    if (a == 3) { Console.WriteLine("тринадцать"); }
                    if (a == 4) { Console.WriteLine("четырнадцать"); }
                    if (a == 5) { Console.WriteLine("пятнадцать"); }
                    if (a == 6) { Console.WriteLine("шестнадцать"); }
                    if (a == 7) { Console.WriteLine("семнадцать"); }
                    if (a == 8) { Console.WriteLine("восемнадцать"); }
                    if (a == 9) { Console.WriteLine("девятнадцать"); }
                }


                {
                    if (b == 2) { Console.WriteLine("двадцать"); }
                    if (b == 3) { Console.WriteLine("тридцать"); }
                    if (b == 4) { Console.WriteLine("сорок"); }
                    if (b == 5) { Console.WriteLine("пятьдесят"); }
                    if (b == 6) { Console.WriteLine("шестьдесят"); }
                    if (b == 7) { Console.WriteLine("семьдесят"); }
                    if (b == 8) { Console.WriteLine("восемьдесят"); }
                    if (b == 9) { Console.WriteLine("девяносто"); }
                }


                {
                    if (c == 1) { Console.WriteLine("один"); }
                    if (c == 2) { Console.WriteLine("два"); }
                    if (c == 3) { Console.WriteLine("три"); }
                    if (c == 4) { Console.WriteLine("четыре"); }
                    if (c == 5) { Console.WriteLine("пять"); }
                    if (c == 6) { Console.WriteLine("шесть"); }
                    if (c == 7) { Console.WriteLine("семь"); }
                    if (c == 8) { Console.WriteLine("восемь"); }
                    if (c == 9) { Console.WriteLine("девять"); }
                }
        }
    }
}

