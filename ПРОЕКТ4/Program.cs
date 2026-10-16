using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОЕКТ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 365: ");
            int day = int.Parse(Console.ReadLine());
             
            if (day < 1 || day > 365)
            {
                Console.WriteLine("Ошибка: число должно быть от 1 до 365!");
            }
            else
            {
                int monthNumber = 0;
                string monthName = "";

                if (day <= 31)
                {
                    monthNumber = 1;
                    monthName = "января";
                }
                else if (day <= 59)
                {
                    monthNumber = 2;
                    monthName = "февраля";
                    day = day - 31;
                }
                else if (day <= 90)
                {
                    monthNumber = 3;
                    monthName = "марта";
                    day = day - 59;
                }
                else if (day <= 120)
                {
                    monthNumber = 4;
                    monthName = "апреля";
                    day = day - 90;
                }
                else if (day <= 151)
                {
                    monthNumber = 5;
                    monthName = "мая";
                    day = day - 120;
                }
                else if (day <= 181)
                {
                    monthNumber = 6;
                    monthName = "июня";
                    day = day - 151;
                }
                else if (day <= 212)
                {
                    monthNumber = 7;
                    monthName = "июля";
                    day = day - 181;
                }
                else if (day <= 243)
                {
                    monthNumber = 8;
                    monthName = "августа";
                    day = day - 212;
                }
                else if (day <= 273)
                {
                    monthNumber = 9;
                    monthName = "сентября";
                    day = day - 243;
                }
                else if (day <= 304)
                {
                    monthNumber = 10;
                    monthName = "октября";
                    day = day - 273;
                }
                else if (day <= 334)
                {
                    monthNumber = 11;
                    monthName = "ноября";
                    day = day - 304;
                }
                else
                {
                    monthNumber = 12;
                    monthName = "декабря";
                    day = day - 334;
                }

                Console.WriteLine("Месяц: " + monthNumber);
                Console.WriteLine("День: " + day + " " + monthName);
            }

            Console.ReadKey();
        }
    }
}
