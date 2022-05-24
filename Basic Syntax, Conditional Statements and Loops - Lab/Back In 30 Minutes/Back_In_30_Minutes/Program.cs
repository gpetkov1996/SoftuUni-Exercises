using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if ((minutes + 30) >= 60)
            {
                hour++;
                minutes = (minutes + 30) % 60;
            }
            else
            {
                minutes = minutes + 30;
            }
            if (hour >= 24)
            {
                hour = hour % 24;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
