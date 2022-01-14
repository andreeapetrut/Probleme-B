using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, x, y, r;
            Console.WriteLine("a= ");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b= ");
             b = Convert.ToInt32(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            Console.WriteLine("cmmdc: "); Console.WriteLine(a);

            x = a;
            y = b;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            int c = x * y / a;

            Console.WriteLine("cmmc: "); Console.WriteLine(c);


        }
    }
}
