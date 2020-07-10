using System;

namespace ConditionExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naciśnij dowolny klawisz: ");
            var input = Console.ReadKey();
            var inputChar = Convert.ToChar(input.KeyChar);
            Console.WriteLine();
            if (inputChar >= 'a' && inputChar <= 'z' || inputChar >= 'A' && inputChar <= 'Z') Console.WriteLine("Wcisnąłeś literę.");
            else Console.WriteLine("Wcisnąłeś inny klawisz.");

            
            
            //another way to do this

            //if (Char.IsLetter(Convert.ToChar(input))) Console.WriteLine("Wcisnąłeś literę.");
            //else Console.WriteLine("Wcisnąłeś inny klawisz.");
        }
    }
}
