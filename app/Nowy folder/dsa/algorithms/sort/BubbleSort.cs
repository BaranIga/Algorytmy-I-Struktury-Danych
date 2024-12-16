namespace dsa.algorithms.sort
{
    class BubbleSort : ISortingAlgorithm
    {
        public void Sort(int[] data)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        Swap(data, i, i + 1);
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }

        private void Swap(int[] data, int idx1, int idx2)
        {
            int temp = data[idx1];
            data[idx1] = data[idx2];
            data[idx2] = temp;
        }
    }
}
