using System;

namespace ConditionExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrongInput = false;
            do
            {
                Console.WriteLine("Program podaje liczbę dni w podanym miesiącu.");
                Console.WriteLine("Podaj numer miesiąca (1-12): ");

                int numberOfMonth;
                if (int.TryParse(Console.ReadLine(), out numberOfMonth))
                {
                    if (numberOfMonth == 1 || numberOfMonth == 3 || numberOfMonth == 5 || numberOfMonth == 7
                    || numberOfMonth == 8 || numberOfMonth == 10 || numberOfMonth == 12)
                    {
                        Console.WriteLine("Podany miesiąc ma 31 dni.");
                    }
                    else if (numberOfMonth == 2)
                    {
                        Console.WriteLine("Podany miesiąc ma 28 dni, a co cztery lata 29.");
                    }
                    else
                    {
                        Console.WriteLine("Podany miesiąc ma 30 dni.");
                    }

                    wrongInput = false;
                }
                else wrongInput = true;
            } while (wrongInput);
        }
    }
}
