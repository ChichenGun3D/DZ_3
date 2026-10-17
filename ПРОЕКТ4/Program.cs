
using System;

class Program
{
    enum DaysOfWeek
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    static void Main()
    {
        Console.Write("Введите номер дня недели (от 1 до 7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            DaysOfWeek day = (DaysOfWeek)dayNumber;
            Console.WriteLine(day);
        }
        else
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 7.");
        }

        Console.ReadKey();
    }
}