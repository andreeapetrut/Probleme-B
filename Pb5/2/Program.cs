using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Să se determine numerele perfecte din intervalul [a,b], pentru a,b date.

            int a, b, ok=0;

            Console.WriteLine("a= "); 
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b= ");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    if ((i % j == 0) && (i / j == j))
                    {
                        Console.WriteLine(i);
                        ok = 1;
                    }
                }
            }
            if (ok == 0)
            {
                Console.WriteLine("Nu s-a gasit niciun numar patrat perfect in intervalul a,b");
            }
        }
    }
}
