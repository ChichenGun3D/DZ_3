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
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите число от 1 до 366: ");
            int day = int.Parse(Console.ReadLine());

            bool isLeap = false;
            if (year % 400 == 0)
            {
                isLeap = true;
            }
            else if (year % 100 == 0)
            {
                isLeap = false;
            }
            else if (year % 4 == 0)
            {
                isLeap = true;
            }

            int februaryDays;
            if (isLeap)
            {
                februaryDays = 29;
            }
            else
            {
                februaryDays = 28;
            }

            int maxDay;
            if (isLeap)
            {
                maxDay = 366;
            }
            else
            {
                maxDay = 365;
            }

            if (day < 1 || day > maxDay)
            {
                Console.WriteLine("Ошибка: число должно быть от 1 до " + maxDay + "!");
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
                else if (day <= 31 + februaryDays)
                {
                    monthNumber = 2;
                    monthName = "февраля";
                    day = day - 31;
                }
                else if (day <= 31 + februaryDays + 31)
                {
                    monthNumber = 3;
                    monthName = "марта";
                    day = day - (31 + februaryDays);
                }
                else if (day <= 31 + februaryDays + 31 + 30)
                {
                    monthNumber = 4;
                    monthName = "апреля";
                    day = day - (31 + februaryDays + 31);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31)
                {
                    monthNumber = 5;
                    monthName = "мая";
                    day = day - (31 + februaryDays + 31 + 30);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30)
                {
                    monthNumber = 6;
                    monthName = "июня";
                    day = day - (31 + februaryDays + 31 + 30 + 31);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30 + 31)
                {
                    monthNumber = 7;
                    monthName = "июля";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31)
                {
                    monthNumber = 8;
                    monthName = "августа";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30 + 31);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30)
                {
                    monthNumber = 9;
                    monthName = "сентября";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31)
                {
                    monthNumber = 10;
                    monthName = "октября";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30);
                }
                else if (day <= 31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30)
                {
                    monthNumber = 11;
                    monthName = "ноября";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31);
                }
                else
                {
                    monthNumber = 12;
                    monthName = "декабря";
                    day = day - (31 + februaryDays + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30);
                }

                Console.WriteLine("Год: " + year);
                Console.WriteLine("Месяц: " + monthNumber);
                Console.WriteLine("День: " + day + " " + monthName);
            }

            Console.ReadKey();
        }
    }
}