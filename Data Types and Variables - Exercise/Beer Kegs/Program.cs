using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVol = 0;

            for (int i = 0; i < n; i++)
            {
                string currKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * hight;

                if (volume > biggestVol) // присвояване на стоиност за наи голяма стоиност
                {

                    biggestVol = volume;
                    biggestKeg = currKeg;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
