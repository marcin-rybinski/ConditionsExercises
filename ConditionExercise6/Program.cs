using System;

namespace ConditionExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            GetFunctionParams(out a, out b, out c);
            CalculateRoots(a,b,c);
        }

        private static void GetFunctionParams(out double a, out double b, out double c)
        {
            Console.WriteLine("Program oblicza pierwiastki równania kwadratowego ax^2 + bx + c = 0.");
            Console.Write("Podaj a: ");
            if (double.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                b = 0;
                c = 0;
                return;
            }

            Console.Write("Podaj b: ");
            if (double.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                c = 0;
                return;
            }
            Console.Write("Podaj c: ");
            if (double.TryParse(Console.ReadLine(), out c) == false)
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                return;
            }
        }

        private static void CalculateRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                var x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                var x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Równanie ma dwa pierwiastki: {x1} i {x2}");
            }
            else if (delta == 0)
            {
                var x = -(b / (2 * a));
                Console.WriteLine($"Równanie ma jeden pierwiastek: {x}");
            }
            else
            {
                Console.WriteLine("Równanie nie ma pierwiastków.");
            }
        }
    }
}
