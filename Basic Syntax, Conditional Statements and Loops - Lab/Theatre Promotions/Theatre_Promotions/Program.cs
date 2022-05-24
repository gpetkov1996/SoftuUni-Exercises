using System;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int priceSingleTicket = 0;

            if(age >=0 && age <= 18)
            {
                if(typeOfDay == "Weekday")
                {
                    priceSingleTicket = 12;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if(typeOfDay == "Weekend")
                {
                    priceSingleTicket = 15;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    priceSingleTicket = 5;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
            }
            if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    priceSingleTicket = 18;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if (typeOfDay == "Weekend")
                {
                    priceSingleTicket = 20;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    priceSingleTicket = 12;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
            }
            if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    priceSingleTicket = 12;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if (typeOfDay == "Weekend")
                {
                    priceSingleTicket = 15;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
                else if (typeOfDay == "Holiday")
                {
                    priceSingleTicket = 10;
                    Console.WriteLine($"{priceSingleTicket}$");
                }
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        } 
    }
}
