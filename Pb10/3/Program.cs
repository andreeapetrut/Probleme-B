using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            bool prim = true;

            Console.WriteLine("n=");
            n = Convert.ToInt32(Console.ReadLine());

            while(n!=0)
            {
                prim = true;
                if (i < 2)
                { 
                    prim = false;
                }
                for (int d = 2; d * d <= n; d++)
                    if (i % d == 0)
                    {
                        prim = false;
                    }
                if (prim == true)
                {
                    Console.WriteLine(i);
                    n--;
                }
                i++;
            }
        }
    }
}
