using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lightsaber

            // Belt

            // Robe

            // Lightsabres sometimes break, so John should buy 10 % more(taken from the students' count), rounded up to the next integer.

            // Every sixth belt is free

            double moneyJohn = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());

            double finalPriceLightsaber = ((priceLightsaber * ((int)Math.Ceiling(numberOfStudents + (numberOfStudents * 0.1)))));
            int v = numberOfStudents / 6;
            double finalPriceRobe = priceRobe * (numberOfStudents - v);
            

            double total = finalPriceLightsaber + priceBelt * numberOfStudents + finalPriceRobe;
            if (total <= moneyJohn)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(total - moneyJohn):F2}lv more.");
            }
        }
    }
}
˜