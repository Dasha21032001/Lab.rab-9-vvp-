using System;

namespace Лаб.раб__9
{
    class Program
    {
        static void Main(string[] args)
        {
            int D, M;
            Console.WriteLine("Введите номер дня от 1 до 31 ");
            D = Convert.ToInt32(Console.ReadLine());//вывод номера дня
            Console.WriteLine("Введите номер месяца от 1 до 12");
            M = Convert.ToInt32(Console.ReadLine());//вывод номера месяца
           
            if (D == 10) { Console.WriteLine("десятое"); }
            if (D == 11) { Console.WriteLine("одиннадцатое"); }
            if (D == 12) { Console.WriteLine("двенадцатое"); }
            if (D == 13) { Console.WriteLine("тринадцатое"); }
            if (D == 14) { Console.WriteLine("четырнадцатое"); }
            if (D == 15) { Console.WriteLine("пятнадцатое"); }
            if (D == 16) { Console.WriteLine("шестнадцатое"); }
            if (D == 17) { Console.WriteLine("семнадцатое"); }
            if (D == 18) { Console.WriteLine("восемнадцатое"); }
            if (D == 19) { Console.WriteLine("девятнадцатое"); }
            if (D == 20) { Console.WriteLine("двадцатое"); }
            if (D == 21) { Console.WriteLine("двадцать первое"); }
            if (D == 22) { Console.WriteLine("двадцать второе"); }
            if (D == 23) { Console.WriteLine("двадцать третье"); }
            if (D == 24) { Console.WriteLine("двадцать четвёртое"); }
            if (D == 25) { Console.WriteLine("двадцать пятое"); }
            if (D == 26) { Console.WriteLine("двадцать шестое"); }
            if (D == 27) { Console.WriteLine("двадцать седьмое"); }
            if (D == 28) { Console.WriteLine("двадцать восьмое"); }
            if (D == 29) { Console.WriteLine("двадцать дквятое"); }
            if (D == 30) { Console.WriteLine("тридцатое"); }
            if (D == 31) { Console.WriteLine("тридцать первое"); }

            if (M == 1) { Console.WriteLine("января"); }
            if (M == 2) { Console.WriteLine("февраля"); }
            if (M == 3) { Console.WriteLine("марта"); }
            if (M == 4) { Console.WriteLine("апреля"); }
            if (M == 5) { Console.WriteLine("мая"); }
            if (M == 6) { Console.WriteLine("июня"); }
            if (M == 7) { Console.WriteLine("июля"); }
            if (M == 8) { Console.WriteLine("августа"); }
            if (M == 9) { Console.WriteLine("сентября"); }
            if (M == 10) { Console.WriteLine("октября"); }
            if (M == 11) { Console.WriteLine("ноября"); }
            if (M == 12) { Console.WriteLine("декабря"); }
            Console.Read();
        }
    }
}
