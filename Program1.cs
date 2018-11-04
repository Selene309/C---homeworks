using System;

namespace zadanie_domowe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 1 liczbe");

            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Podaj 2 liczbe");

            int b = Convert.ToInt32(Console.ReadLine());
 
            int liczba = a*b;


            Console.WriteLine($"Wynik mnozenia: {liczba}");

            if (liczba >= 15) Console.WriteLine($"Liczba {liczba} jest wieksza lub rowna od 15");
            if (liczba < 15) Console.WriteLine($"Liczba {liczba} jest mniejsza od 15");


            Console.ReadKey();

        }
    }
}
