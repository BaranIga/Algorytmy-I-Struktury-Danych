namespace dsa.structures.list
{
    internal class ListNode<T>
    {

        public ListNode<T>? Next { get; set; }
        public ListNode<T>? Prev { get; set; }
        public T Data { get; set; }

        public ListNode(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
