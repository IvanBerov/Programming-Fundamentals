using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            if (times > 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
            }
            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }

            //int number = int.Parse(Console.ReadLine());​
            //int times = int.Parse(Console.ReadLine());​

            // do​
            //  {​

            //   Console.WriteLine(​$"{number} X {times} = {number * times}"​);
            //   times++;​

            //  } while (times <= 10) ;

        }
    }
}
