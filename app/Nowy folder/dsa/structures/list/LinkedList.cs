namespace dsa.structures.list
{
    internal class LinkedList<T>
    {
        private ListNode<T>? Head { get; set; }
        private ListNode<T>? Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void AddFirst(T value)
        {
            if (AddIfEmpty(value)) return;
            ListNode<T> node = new ListNode<T>(value);
            Head.Prev = node;
            node.Next = Head;
            Head = node;
            Count++;
        }

        public void AddLast(T value)
        {
            if (AddIfEmpty(value)) return;
            ListNode<T> node = new ListNode<T>(value);
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
            Count++;
        }

        private bool AddIfEmpty(T value)
        {
            if (IsEmpty())
            {
                ListNode<T> node = new ListNode<T>(value);
                Head = node;
                Tail = node;
                Count++;
                return true;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (IsEmpty()) return;
            if (RemoveIfSingle()) return;
            Head = Head.Next;
            Head.Prev = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty()) return;
            if (RemoveIfSingle()) return;
            Tail = Tail.Prev;
            Tail.Next = null;
            Count--;
        }

        private bool RemoveIfSingle()
        {
            if (Count == 1)
            {
                Head = null;
                Tail = null;
                Count = 0;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (IsEmpty())
            {
                return "[]";
            }
            string str = "[";
            ListNode<T>? cur = Head;
            bool isFirst = true;
            while (cur != null)
            {
                if (isFirst)
                {
                    str = string.Concat(str, cur.Data);
                    isFirst = false;
                }
                else
                {
                    str = string.Concat(str, ", ", cur.Data);
                }
                cur = cur.Next;
            }
            return string.Concat(str, "]");
        }
    }
}
