using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleOnVacation = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;
            double priceForVacation = 0;

            //            Friday Saturday Sunday

            //Students    8.45   9.80     10.46

            //Business    10.90  15.60    16

            //Regular     15     20       22.50

            if (groupType == "Students" && dayOfWeek == "Friday")
            {
                pricePerPerson = 8.45;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Students" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 9.80;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Students" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 10.46;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Business" && dayOfWeek == "Friday")
            {
                pricePerPerson = 10.90;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Business" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 15.60;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Business" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 16;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Regular" && dayOfWeek == "Friday")
            {
                pricePerPerson = 15;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Regular" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 20;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            else if (groupType == "Regular" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 22.50;
                priceForVacation = peopleOnVacation * pricePerPerson;
            }
            if (groupType == "Students" && peopleOnVacation >= 30)
            {
                priceForVacation = priceForVacation - (priceForVacation * 0.15);
            }
            else if (groupType == "Business" && peopleOnVacation >= 100)
            {
                priceForVacation = priceForVacation - (10 * pricePerPerson);
            }
            else if (groupType == "Regular" && peopleOnVacation >= 10 && peopleOnVacation <= 20)
            {
                priceForVacation = priceForVacation - (priceForVacation * 0.05);
            }
            Console.WriteLine($"Total price: {priceForVacation:F2}");
        }
    }
}
