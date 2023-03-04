using System;
using System.Text.RegularExpressions;
namespace _03._03._2023LB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            ////////////////////
            Console.Write("Введите свой IP-адрес --->");
            string IP = Convert.ToString(Console.ReadLine());
            string PATTERN = @"((\w+){3}).((\w+){3}).((\w+){3}).((\w){3})$";
            Regex regex = new Regex(PATTERN);
            if (regex.IsMatch(IP))
            {
                Console.WriteLine("Вы ввели IP правильно!!");
            }
            else
            {
                Console.WriteLine("Вы ввели IP не правильно!!");
            }

            ////////////////////
            Console.Write("Введите URL ресурса --->");
            string URL = Convert.ToString(Console.ReadLine());
            string PatternURL = @"http://((w+){1,10}).((w+){1,10}).com$";
            Regex regex1 = new Regex(PatternURL);
            if (regex1.IsMatch(URL))
            {
                Console.WriteLine("Ваш ввод URL правильный!!!");
            }
            else
            {
                Console.WriteLine("Ваш ввод URL не правильный!!!");
            }

            ////////////////////
            Console.Write("Введите индекс США --->");
            string Index = Convert.ToString(Console.ReadLine());
            string P = @"((\d+){1,10})-((\d+){1,10})$";
            Regex reg = new Regex(P);
            if (reg.IsMatch(Index))
            {
                Console.WriteLine("Вы ввели правельный формат индекса!!!");
            }
            else
            {
                Console.WriteLine("Вы ввели не правельный формат индекса!!!");
            }

            /////////////////////
            Console.Write("Введите время в формате часы.мин.сек --->");
            string Time = Convert.ToString(Console.ReadLine());
            string FormatTime = @"(([01][0-9])|([2][0-3])).[0-5][0-9].([0-5][0-9])$";
            Regex TimeR = new Regex(FormatTime);
            if (TimeR.IsMatch(Time))
            {
                Console.WriteLine("Формат времени введен правильно!!!");
            }
            else
            {
                Console.WriteLine("Формат времени введен не правильно!!!");
            }

            ////////////////////
            Console.Write("Введите гласные буквы ---> ");
            string Word = Convert.ToString(Console.ReadLine());
            string F = @"(а|е|ё|и|й|о|у|ы|ь|э|ю|я|)$";
            Regex R = new Regex(F);
            int Count = 0;
            if (R.IsMatch(Word))
            {
                Count++;
            }
            Console.WriteLine("Количество глассных букв = "+Count);
        }
    }
}
