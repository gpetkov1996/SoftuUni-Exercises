using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //((daysInMonth * capsulesCount) * pricePerCapsule)

            int n = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());
            double total = 0;
            int counter = n;
            if (n == 1)
            {
                double formula = ((days * capsuleCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${formula:F2}");
                total += formula;
                Console.WriteLine($"Total: ${total:F2}");
            }
            else
            {
                for (int i =  1; i <= n; i++)
                {
                    double formula = ((days * capsuleCount) * pricePerCapsule);

                    Console.WriteLine($"The price for the coffee is: ${formula:F2}");
                    total += formula;
                    if (i < n)
                    {
                        pricePerCapsule = double.Parse(Console.ReadLine());
                        days = int.Parse(Console.ReadLine());
                        capsuleCount = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine($"Total: ${total:F2}");
            }
        }
    }
}
