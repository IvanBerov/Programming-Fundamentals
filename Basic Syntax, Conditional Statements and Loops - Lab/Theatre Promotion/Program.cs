using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (0 <= age && age <= 18)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfDay == "weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
            }
            else if (64 < age && age <= 122)
            {
                if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
            }
            if (age > 0 && age < 123)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
