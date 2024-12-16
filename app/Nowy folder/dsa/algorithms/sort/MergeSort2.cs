namespace dsa.algorithms.sort
{
    internal class MergeSort2 : ISortingAlgorithm
    {
        public void Sort(int[] data)
        {
            int[] sorted = Split(data);
            Array.Copy(sorted, data, data.Length);
        }

        private int[] Split(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int mid = array.Length / 2;
            int leftArrayLen = mid;
            int rightArrayLen = array.Length - mid;
            int[] leftArray = new int[leftArrayLen];
            int[] rightArray = new int[rightArrayLen];
            Array.Copy(array, 0, leftArray, 0, leftArrayLen);
            Array.Copy(array, mid, rightArray, 0, rightArrayLen);
            int[] left = Split(leftArray);
            int[] right = Split(rightArray);
            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] combined = new int[left.Length + right.Length];
            int index = 0, i = 0, j = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    combined[index] = left[i];
                    index++;
                    i++;
                }
                else
                {
                    combined[index] = right[j];
                    index++;
                    j++;
                }
            }
            while (i < left.Length)
            {
                combined[index] = left[i];
                index++;
                i++;
            }
            while (j < right.Length)
            {
                combined[index] = right[j];
                index++;
                j++;
            }
            return combined;
        }
    }
}
