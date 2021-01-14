using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int yers = centuries * 100;
            int days = (int)(yers * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {yers} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
