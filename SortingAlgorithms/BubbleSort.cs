namespace SortingAlgorithms
{
    internal class BubbleSort : Algorithm
    {
        protected override void Run()
        {
            int n = Length;
            do
            {
                int newn = 0;
                for (int i = 1; i < n; i++)
                {
                    if (Gt(i - 1, i))
                    {
                        Swap(i - 1, i);
                        newn = i;
                    }
                }

                n = newn;
            } while (n > 1);
        }
    }
}