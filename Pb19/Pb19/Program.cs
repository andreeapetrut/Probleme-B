using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ce doriti sa calculam? Aria sau perimetrul?");
            var input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();
            }

            var perimeter = a + b + c;

                switch (input.ToLower())
                {
                    case "aria":
                        var area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b) * (perimeter / 2 - c));
                        Console.WriteLine();
                        Console.WriteLine($"Aria este: {area}.");
                        break;
                    case "perimetrul":
                        Console.WriteLine();
                        Console.WriteLine($"Perimetrul este: {perimeter}");
                        break;
                    default:
                        Console.WriteLine("Optiunea nu exista!");
                        break;
                }
        }
    }
}
