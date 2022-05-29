using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double moneyForHeadset = (lostGames / 2) * headsetPrice;
            double moneyForMouse = (lostGames / 3) * mousePrice;
            double moneyForKeyboard = (lostGames / 6) * keyboardPrice;
            double moneyForDisplay = (lostGames / 12) * displayPrice;

            double rageExpenses = moneyForHeadset + moneyForMouse + moneyForKeyboard + moneyForDisplay;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
