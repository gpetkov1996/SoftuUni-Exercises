using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.1, 0.2, 0.5, 1 and 2 - valid coins
            //If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.

            string command = Console.ReadLine();

            double sum = 0;

            while (command != "Start")
            {
                double coins;
                Double.TryParse(command, out coins);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    command = Console.ReadLine();
                }
            }

            if (command == "Start")
            {
                command = Console.ReadLine();

                while (command != "End")
                {
                    if (command == "Nuts")
                    {
                        if (sum - 2 >= 0)
                        {
                            sum -= 2.0;
                            Console.WriteLine($"Purchased nuts");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                    }
                    else if (command == "Water")
                    {
                        if (sum - 0.7 >= 0)
                        {
                            sum -= 0.7;
                            Console.WriteLine($"Purchased water");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }

                    }
                    else if (command == "Crisps")
                    {
                        if (sum - 1.5 >= 0)
                        {
                            sum -= 1.5;
                            Console.WriteLine($"Purchased crisps");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                    }
                    else if (command == "Soda")
                    {
                        if (sum - 0.8 >= 0)
                        {
                            sum -= 0.8;
                            Console.WriteLine($"Purchased soda");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                    }
                    else if (command == "Coke")
                    {
                        if (sum - 1 >= 0)
                        {
                            sum -= 1;
                            Console.WriteLine($"Purchased coke");
                            command = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            command = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                    }
                }
            }

            if (command == "End")
            {
                Console.WriteLine($"Change: {sum:F2}");
            }
        }
    }
}
