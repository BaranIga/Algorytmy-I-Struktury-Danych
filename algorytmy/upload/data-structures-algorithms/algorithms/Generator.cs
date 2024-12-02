using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class Generator
    {

        private Random _rand;
        public Random Rand
        {
            get { return _rand; }
            set { _rand = value; }
        }

        public Generator()
        {
            this.Rand = new Random();
        }

        public int[] RandArray(int length, int min, int max)
        {
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Rand.Next(min, max);
            }
            return arr;
        }
    }
}
