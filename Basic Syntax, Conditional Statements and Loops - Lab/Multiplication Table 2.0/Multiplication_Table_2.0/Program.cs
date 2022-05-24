using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = int.Parse(Console.ReadLine());


            if (counter > 10)
            {
                Console.WriteLine($"{number} X {counter} = {number * counter}");
            }
            else
            {
                while (counter <= 10)
                {
                    Console.WriteLine($"{number} X {counter} = {number * counter}");
                    counter++;

                }
            }

        }
    }
}
