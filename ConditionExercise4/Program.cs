using System;

namespace ConditionExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza, czy podana litera to samogłoska czy spółgłoska.");
            Console.WriteLine("Podaj literę: ");
            var input = Console.ReadKey();
            var inputChar = Convert.ToChar(input.KeyChar);
            Console.WriteLine();
            if (inputChar >= 'a' && inputChar <= 'z' || inputChar >= 'A' && inputChar <= 'Z')
            {
                if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o'
                    || inputChar == 'u' || inputChar == 'y' || inputChar == 'A' || inputChar == 'E'
                    || inputChar == 'I' || inputChar == 'O' || inputChar == 'U' || inputChar == 'Y')
                    Console.WriteLine("Podałeś samogłoskę.");
                else Console.WriteLine("Podałeś spółgłoskę.");
            }
            else Console.WriteLine("Nie podałeś litery!");
        }
    }
}
