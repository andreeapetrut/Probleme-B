using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch

            int C, F, opt;

            Console.WriteLine("Meniu");
            Console.WriteLine("1.Celsius -> Fahrenheit");
            Console.WriteLine("2.Fahrenheit -> Celsius");
            opt = Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:
                    C = 0; F = 0;
                    Console.WriteLine("Introdu gradele Celsius: ");
                    C = Convert.ToInt32(Console.ReadLine());
                    F = (C * 18/10 +32);
                    Console.WriteLine("Gradele Celsius in grade Fahrenheit sunt: "); Console.Write(F);
                    break;
                case 2:
                    C = 0; F = 0;
                    Console.WriteLine("Introdu gradele Fahrenheit: ");
                    F = Convert.ToInt32(Console.ReadLine());
                    C = (F - 32) * 5/9;
                    Console.WriteLine("Gradele Fahrenheit in grade Celsius sunt: "); Console.Write(C);
                    break;
            }
        }
    }
}
