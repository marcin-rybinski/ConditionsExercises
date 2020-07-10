using System;

namespace ConditionExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę jednostek zużycia energii elektrycznej: ");
            decimal units;
            if (decimal.TryParse(Console.ReadLine(), out units) == false) return;
            decimal billAmount;
            var surcharge = new decimal(1.1);
            var priceFirst50 = new decimal(0.5);
            var priceNext100 = new decimal(0.75);
            var priceNext200 = new decimal(1.2);
            var priceNext250 = new decimal(1.5);
            if (units <= 50)
            {
                billAmount = (priceFirst50 * units) * surcharge;
            }
            else if (units <= 150)
            {
                billAmount = ((priceFirst50 * 50) + priceNext100 * (units - 50)) * surcharge;
            }
            else if (units <= 350)
            {
                billAmount = (priceFirst50 * 50 + priceNext100 * 100 + priceNext200 * (units - 150)) * surcharge;
            }
            else
            {
                billAmount =
                    (priceFirst50 * 50 + priceNext100 * 100 + priceNext200 * 200 + priceNext250 * (units - 350)) *
                    surcharge;
            }

            Console.WriteLine($"Kwota do zapłaty wynosi: {billAmount}PLN. ");

        }
    }
}
