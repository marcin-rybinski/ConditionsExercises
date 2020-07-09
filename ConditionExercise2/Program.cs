using System;

namespace ConditionExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną, a ja sprawdzę czy jest podzielna zarówno przez 5 jak i przez 11: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 11 == 0) Console.WriteLine("Podana liczba jest podzielna przez 5 i przez 11 !!");
            else if (number % 5 == 0) Console.WriteLine("Podana liczba jest podzielna jedynie przez 5.");
            else if (number % 11 == 0) Console.WriteLine("Podana liczba jest podzielna jedynie przez 11.");
            else Console.WriteLine("Niestety, podana liczba nie jest podzielna ani przez 5 i ani przez 11.");
        }
    }
}
