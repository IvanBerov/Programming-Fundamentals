using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double hight = int.Parse(Console.ReadLine());
            double area = CalculeteArea(width,hight);
            Console.WriteLine(area);


        }

        private static double CalculeteArea(double width,double hight)
        {
            return width * hight;
        }
    }
}
