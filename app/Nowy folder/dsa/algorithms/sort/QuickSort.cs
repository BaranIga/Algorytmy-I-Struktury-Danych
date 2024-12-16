namespace dsa.algorithms.sort
{
    internal class QuickSort : ISortingAlgorithm
    {
        public void Sort(int[] data)
        {
            QS(data, 0, data.Length - 1);
        }

        private static void QS(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Pivot(arr, left, right);
                QS(arr, left, pivotIndex - 1);
                QS(arr, pivotIndex + 1, right);
            }
        }

        private static int Pivot(int[] arr, int pivotIndex, int endIndex)
        {
            int swapIndex = pivotIndex;
            for (int i = pivotIndex + 1; i <= endIndex; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    swapIndex++;
                    Swap(arr, swapIndex, i);
                }
            }
            Swap(arr, pivotIndex, swapIndex);
            return swapIndex;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
