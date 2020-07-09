using System;

namespace ConditionExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj trzy liczby, żeby sprawdzić, która z nich jest największa: ");
            double firstNumber = Double.Parse(Console.ReadLine());
            double secondNumber = Double.Parse(Console.ReadLine());
            double thirdNumber = Double.Parse(Console.ReadLine());
            var highest = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            highest = (highest > thirdNumber) ? highest : thirdNumber;
            Console.WriteLine($"Najwyższa liczba to: {highest}");
        }
    }
}
