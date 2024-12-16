namespace dsa.structures.PriorityQueue
{
    /// <summary>
    /// A binary heap implementation of priority queue.
    /// </summary>
    /// <typeparam name="T">The element's key type.</typeparam>
    public class MinPQ<T> where T : IComparable<T>
    {

        private T[] _pq;
        private int _n;

        public MinPQ(int capacity)
        {
            _pq = new T[capacity];
            _n = 0;
        }

        public void Insert(T key)
        {
            // add to the end
            // then swim up
            _pq[_n++] = key;
            Swim(key);
        }
    }
}
