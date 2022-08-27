using System;

namespace SortingAlgorithms
{
    internal class Shuffle : Algorithm
    {
        protected override void Run()
        {
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                Swap(i, random.Next(Length));
            }
        }
    }
}
