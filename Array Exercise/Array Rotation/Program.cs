using System;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string rotatingElement = arr[0];

                // for loop rotating the Array !!!
                for (int j = 1; j < arr.Length; j++)
                {
                    string currElement = arr[j];
                    arr[j - 1] = currElement;
                }

                arr[arr.Length - 1] = rotatingElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
