using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string lowerCaseInput = input.ToLower();

            //char[] characters = input.ToCharArray();î

            VowelsInString(lowerCaseInput);
        }

        private static void VowelsInString(string input)
        {
            int total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    total++;
                }
            }

            Console.WriteLine($"{total}");
        }
    }
}
