using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int factorial = number % 10;
            int sum = 0;
            int total = 0;

            for (int i = 1; i <=factorial; i++)
            {
                int sumOfNumber = i * (i + 1);
                sum += sumOfNumber * (i +1);
                total = sum;
            }
            Console.WriteLine(sum);
            //int counter = factorial;
            //number = number / 10;
            //int sum = 0;

            //for (int i = counter; i >= 1; i--)
            //{
            //    int sumOfNumber = i * counter;
            //    sum += sumOfNumber;
            //}
        }
    }
}
