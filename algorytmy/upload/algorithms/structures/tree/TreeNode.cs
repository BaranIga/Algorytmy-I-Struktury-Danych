namespace dsa.structures.tree
{
    internal class TreeNode<T> where T : IComparable<T>
    {
        public TreeNode<T>? Parent { get; set; }
        public TreeNode<T>? LeftChild { get; set; }
        public TreeNode<T>? RightChild { get; set; }
        public T Data { get; set; }

        public TreeNode(T data)
        {
            Parent = null;
            LeftChild = null;
            RightChild = null;
            Data = data;
        }
    }
}
