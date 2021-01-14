using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int bestLength = 1;
            int bestSartIndex = 0;
            int bestSeqenceSum = 0;
            int bestSequencIndex = 0;

            int[] bestSeqence = new int[n];

            int sequenceCounter = 0;

            while (input != "Clone them!")
            {
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int bestCurrLength = 1;
                int startIndex = 0;
                int currSeqenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i+1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > bestCurrLength)
                    {
                        bestCurrLength = length;
                        startIndex = i;
                    }
                    currSeqenceSum += currentSequence[i];
                }

                currSeqenceSum += currentSequence[n - 1];

                if (bestCurrLength > bestLength)
                {
                    bestLength = bestCurrLength;
                    bestSartIndex = startIndex;
                    bestSeqenceSum = currSeqenceSum;
                    bestSequencIndex = sequenceCounter;
                    bestSeqence = currentSequence.ToArray();
                }
                else if (bestCurrLength == bestLength)
                {
                    if (startIndex < bestSartIndex)
                    {
                        bestLength = bestCurrLength;
                        bestSartIndex = startIndex;
                        bestSeqenceSum = currSeqenceSum;
                        bestSequencIndex = sequenceCounter;
                        bestSeqence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestSartIndex )
                    {
                        if (currSeqenceSum > bestSeqenceSum)
                        {
                            bestLength = bestCurrLength;
                            bestSartIndex = startIndex;
                            bestSeqenceSum = currSeqenceSum;
                            bestSequencIndex = sequenceCounter;
                            bestSeqence = currentSequence.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequencIndex} with sum: {bestSeqenceSum}.");
            Console.WriteLine(String.Join(' ', bestSeqence));
        }
    }
}
