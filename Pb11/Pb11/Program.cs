using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, r;

            Console.WriteLine("a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            r = a % b;

            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            if (b == 1)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }
    }
}
