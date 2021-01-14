using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneyReceive = Console.ReadLine();
            double insertAmount = 0;

            while (moneyReceive!="Start") // логика за монетите
            {
                double currentCoin = double.Parse(moneyReceive);

                if (currentCoin == 0.1||
                    currentCoin == 0.2||
                    currentCoin == 0.5||
                    currentCoin ==  1 ||
                    currentCoin == 2)
                {
                    insertAmount += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                moneyReceive = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;                     // пропускаме кода надолу
                }
                if (productPrice <= insertAmount)
                {
                    insertAmount -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {insertAmount:f2}");

        }
    }
}
