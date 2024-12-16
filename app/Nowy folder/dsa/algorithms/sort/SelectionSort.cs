namespace dsa.algorithms.sort
{
    internal class SelectionSort : ISortingAlgorithm
    {
        public void Sort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                int curMinIndex = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[curMinIndex])
                    {
                        curMinIndex = j;
                    }
                }
                Swap(data, i, curMinIndex);
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
