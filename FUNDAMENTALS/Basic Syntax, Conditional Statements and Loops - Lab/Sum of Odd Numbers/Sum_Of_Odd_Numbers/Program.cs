using System;

namespace Sum_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for(int oddNumber = 1; oddNumber <= 100; oddNumber++)
            {

                if (oddNumber % 2 != 0)
                {
                    Console.WriteLine(oddNumber);
                    sum += oddNumber;
                    counter++;
                }
                if (counter == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                    return;
                }
            }
        }
    }
}
