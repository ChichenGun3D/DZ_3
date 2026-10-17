
using System;

class Program
{
    static void Main()
    {
        string[] items = { "Hello Kitty", "Car", "Barbie doll", "Book", "Hello Kitty", "Barbie doll", "Phone" };

        int bag = 0;

        foreach (string item in items)
        {
            if (item == "Hello Kitty" || item == "Barbie doll")
            {
                bag = bag + 1;
            }
        }

        Console.WriteLine("Кукол в сумке: " + bag);
        Console.ReadKey();
    }
}
