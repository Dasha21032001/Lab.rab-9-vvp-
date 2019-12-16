using System;

namespace задание_2
{
    class Program
    {

        static char Next(char ishodn, int Command)
        {
            switch (ishodn)
            {
                case 'Ю':
                    switch (Command)
                    {
                        case -1: return 'З';
                        case 0: return 'Ю';
                        case 1: return 'В';
                        default: throw new ArgumentException();
                    }
                case 'В':
                    switch (Command)
                    {
                        case -1: return 'Ю';
                        case 0: return 'В';
                        case 1: return 'С';
                        default: throw new ArgumentException();
                    }
                case 'С':
                    switch (Command)
                    {
                        case -1: return 'В';
                        case 0: return 'С';
                        case 1: return 'З';
                        default: throw new ArgumentException();
                    }
                case 'З':
                    switch (Command)
                    {
                        case -1: return 'С';
                        case 0: return 'З';
                        case 1: return 'Ю';
                        default: throw new ArgumentException();
                    }
                default: throw new ArgumentException();
            }
        }

        static void Main()
        {
            try
            {
                Console.Write("Направление: ");
                var d = Console.ReadLine()[0];
                Console.Write("Команда: ");
                var c = int.Parse(Console.ReadLine());
                Console.WriteLine("Новое направление: " + Next(d, c));
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
                Console.ReadLine();
            }
        }
    }
}      
