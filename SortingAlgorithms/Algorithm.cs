using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal abstract class Algorithm
    {
        private int[] array;
        private int compares;
        private int swaps;

        public event EventHandler<UpdateEventArgs> Update;

        public void Run(int[] array)
        {
            this.array = array;
            compares = 0;
            swaps = 0;
            Run();
        }

        protected int Length => array.Length;

        protected abstract void Run();

        protected void Cursor(int i)
        {
            Update?.Invoke(this, new UpdateEventArgs() { Cursor = i });
        }

        protected bool Eq(int i1, int i2)
        {
            compares++;
            return array[i1] == array[i2];
        }

        protected bool Gt(int i1, int i2)
        {
            compares++;
            return array[i1] > array[i2];
        }

        protected bool Gte(int i1, int i2)
        {
            compares++;
            return array[i1] >= array[i2];
        }

        protected bool Lt(int i1, int i2)
        {
            compares++;
            return array[i1] < array[i2];
        }

        protected bool Lte(int i1, int i2)
        {
            compares++;
            return array[i1] <= array[i2];
        }

        protected bool Ne(int i1, int i2)
        {
            compares++;
            return array[i1] != array[i2];
        }

        protected void Swap(int i1, int i2)
        {
            (array[i2], array[i1]) = (array[i1], array[i2]);
            swaps++;
        }
    }
}
