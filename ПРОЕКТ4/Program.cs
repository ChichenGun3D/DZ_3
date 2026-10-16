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
            try
            {
                Console.Write("Введите номер карты (от 6 до 14): ");
                int k = int.Parse(Console.ReadLine());

                string name = "";

                if (k == 11)
                {
                    name = "валет";
                }
                else if (k == 12)
                {
                    name = "дама";
                }
                else if (k == 13)
                {
                    name = "король";
                }
                else if (k == 14)
                {
                    name = "туз";
                }
                else if (k >= 6 && k <= 10)
                {
                    name = k + "ка";
                }
                else
                {
                    name = "неизвестная карта";
                }

                Console.WriteLine("Достоинство карты: " + name);
            }
            catch
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}