using System;

namespace задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
                int a;
            Console.WriteLine("Введите год:  ");
            int N = Convert.ToInt32(Console.ReadLine());//вывод года
            string s = Console.ReadLine();
            a = N % 60;
            switch ( N % 10)
                {
                    case 0: s = "бел"; break;
                    case 1: s = "бел"; break;
                    case 2: s = "черн"; break;
                    case 3: s = "черн"; break;
                    case 4: s = "зелен"; break;
                    case 5: s = "зелен"; break;
                    case 6: s = "красн"; break;
                    case 7: s = "красн"; break;
                    case 8: s = "желт"; break;
                    case 9: s = "желт"; break;
                }
                switch (a % 12)
                {
                    case 0: s += "ая обезьяна"; break;
                    case 1: s += "ая курица"; break;
                    case 2: s += "ая собака"; break;
                    case 3: s += "ая свинья"; break;
                    case 4: s += "ая крыса"; break;
                    case 5: s += "ая корова"; break;
                    case 6: s += "ый тигр"; break;
                    case 7: s += "ый заяц"; break;
                    case 8: s += "ый дракон"; break;
                    case 9: s += "ый змеи"; break;
                    case 10: s += "ая лошадь "; break;
                    case 11: s += "ая овца"; break;
                }
                Console.WriteLine(" {0} ", s);
                Console.ReadLine();

            }
        }
    }
