using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = numPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numPeople * 10.46;
                }
                if (numPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeGroup == "Business")
            {
                if (numPeople >= 100)
                {
                    numPeople -= 10;
                }
                if (day == "Friday")
                {
                    totalPrice = numPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numPeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numPeople * 16.00;
                }
                
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = numPeople * 15.00;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numPeople * 20.00;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numPeople * 22.50;
                }
                if (numPeople >= 10 && numPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
