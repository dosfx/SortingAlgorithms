using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Shuffle : Algorithm
    {
        protected override void Run()
        {
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                Cursor(i);
                Swap(i, random.Next(Length));
            }
        }
    }
}
