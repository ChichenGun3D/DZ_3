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
            int[] numbers = new int[10];

            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Число " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int badIndex = 0;

            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    badIndex = i + 1;
                    break;
                }
            }

            if (badIndex == 0)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine("Последовательность НЕ упорядочена.");
                Console.WriteLine("Порядковый номер первого нарушения: " + badIndex);
            }

            Console.ReadKey();
        }
    }
}