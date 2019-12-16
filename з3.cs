 using System;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число в диапазоне от 10 до 40  ");
            N = Convert.ToInt32(Console.ReadLine());//вывод числа
            string[] names = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать", "двадцать", "двадцать одно", "двадцать два", "двадцать три", "двадцать четыре", "двадцать пять", "двадцать шесть", "двадцать семь", "двадцать восемь", "двадцать девять", "тридцать", "тридцать одно", "тридцать два", "тридцать три", "тридцать четыре", "тридцать пять", "тридцать шесть", "тридцать семь", "тридцать восемь", "тридцать девять", "сорок" };
            string rez="";
            if (N >= 10 && N <= 40)
            {
                if (N == 10) { rez=names[0]; }
                if (N == 11) { rez = names[1]; }
                if (N == 12) { rez = names[2]; }
                if (N == 13) { rez = names[3]; }
                if (N == 14) { rez = names[4]; }
                if (N == 15) { rez = names[5]; }
                if (N == 16) { rez = names[6]; }
                if (N == 17) { rez = names[7]; }
                if (N == 18) { rez = names[8]; }
                if (N == 19) { rez = names[9]; }
                if (N == 20) { rez = names[10]; }
                if (N == 21) { rez = names[11]; }
                if (N == 22) { rez = names[12]; }
                if (N == 23) { rez = names[13]; }
                if (N == 24) { rez = names[14]; }
                if (N == 25) { rez = names[15]; }
                if (N == 26) { rez = names[16]; }
                if (N == 27) { rez = names[17]; }
                if (N == 28) { rez = names[18]; }
                if (N == 29) { rez = names[19]; }
                if (N == 30) { rez = names[20]; }
                if (N == 31) { rez = names[21]; }
                if (N == 32) { rez = names[22]; }
                if (N == 33) { rez = names[23]; }
                if (N == 34) { rez = names[24]; }
                if (N == 35) { rez = names[25]; }
                if (N == 36) { rez = names[26]; }
                if (N == 37) { rez = names[27]; }
                if (N == 38) { rez = names[28]; }
                if (N == 39) { rez = names[29]; }
                if (N == 40) { rez = names[30]; }
            }
            else
            { Console.WriteLine("Ошибка"); }
            Console.WriteLine(rez + "учебных заданий");
            Console.Read();
        }
    }
}
