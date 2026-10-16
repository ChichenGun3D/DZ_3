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
            Console.Write("Введите строку: ");
            string input = Console.ReadLine().ToLower();

            string result;

            if (input == "jabroni")
            {
                result = "Patron Tequila";
            }
            else if (input == "school counselor")
            {
                result = "Anything with Alcohol";
            }
            else if (input == "programmer")
            {
                result = "Hipster Craft Beer";
            }
            else if (input == "bike gang member")
            {
                result = "Moonshine";
            }
            else if (input == "politician")
            {
                result = "Your tax dollars";
            }
            else if (input == "rapper")
            {
                result = "Cristal";
            }
            else
            {
                result = "Beer";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}