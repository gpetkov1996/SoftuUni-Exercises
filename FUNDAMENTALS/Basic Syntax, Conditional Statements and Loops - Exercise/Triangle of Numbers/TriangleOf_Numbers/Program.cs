using System;

namespace TriangleOf_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            //For each row (y)
            for (int y = counter; y <= number; y++)
            {
                //For each column (x)
                for (int x = 1; x <= counter; x++)
                {
                    //Now you need to repeat the same number for each x, but no new line.
                    Console.Write($"{counter} ");
                }
                counter++;
                //Stick the new line on the end of the row to start the next row
                Console.WriteLine();
            }
        }
    }
}
