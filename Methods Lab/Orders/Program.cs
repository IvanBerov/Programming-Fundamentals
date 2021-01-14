using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Orders(command,quantity);
        }

        private static void Orders(string command,int quantity)
        {


            double totalPrice = 0;

            if (command == "coffee")
            {
                totalPrice = 1.50 * quantity;
            }
            else if (command == "water")
            {
                totalPrice = 1.00 * quantity;
            }
            else if (command == "coke")
            {
                totalPrice = 1.4 * quantity;
            }
            else
            {
                totalPrice = 2.00 * quantity;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
