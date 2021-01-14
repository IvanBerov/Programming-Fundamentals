using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headsetPrice * (lostGame / 2);
            money += mousePrice * (lostGame / 3);
            money += keyboardPrice * (lostGame / 6);
            money += displayPrice * (lostGame / 12);

            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
