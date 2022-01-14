using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numar foi: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti numarul de randuri / foaie: ");
            var r = Convert.ToInt32(Console.ReadLine());

            long total = n * r;
            Console.WriteLine();
            Console.WriteLine($"Cartea cu {n} pagini si {r} randuri/pagina are {total} randuri in total.");
        }
    }
}
