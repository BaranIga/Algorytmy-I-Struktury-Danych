 namespace dsa.algorithms
{
    class MergeSort : ISortingAlgorithm
    {

        public void Sort(int[] data)
        {
            Split(data, 0, data.Length - 1);
        }

        private void Split(int[] data, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int mid = (start + end) / 2;
            Split(data, start, mid);
            Split(data, mid + 1, end);
            Merge(data, start, mid, end);
        }

        private void Merge(int[] data, int start, int mid, int end)
        {
            // creating a temporary buffer
            int[] buffer = new int[end+1];
            int t = start;
            while (t <= end)
            {
                buffer[t] = data[t];
                t++;
            }

            // comparing corresponding elements in subarrays
            int i = start, j = mid+1, k = start;
            while (i <= mid && j <= end)
            {
                if (buffer[i] <= buffer[j])
                {
                    data[k++] = buffer[i++];
                }
                else
                {
                    data[k++] = buffer[j++];
                }
            }

            // appending the remaining elements
            while (i <= mid)
            {
                data[k++] = buffer[i++];
            }
            while (j <= end)
            {
                data[k++] = buffer[j++];
            }
        }
    }
}
