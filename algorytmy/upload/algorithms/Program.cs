using dsa.structures.tree;

namespace algorithms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Add(15);
            bst.Add(8);
            bst.Add(14);
            bst.Add(7);
            bst.Add(12);
            bst.Add(10);
            bst.Add(13);
            bst.Add(21);
            bst.Remove2(8);
            bst.Remove2(14);
            bst.Remove2(10);
            //bst.Remove(7);
            //bst.Remove(15);
            //bst.Remove(21);
            //bst.Remove(12);
            //bst.Remove(13);

            BinarySearchTree<int> bst2 = new();
            bst2.Add(8);
            bst2.Add(3);
            bst2.Add(13);
            bst2.Add(2);
            bst2.Add(5);
            bst2.Add(10);
            bst2.Add(27);
            Console.WriteLine($"Inorder: [{String.Join(", ", bst2.DfsInOrder())}]");
            Console.WriteLine($"Preorder: [{String.Join(", ", bst2.DfsPreOrder())}]");
            Console.WriteLine($"Postorder: [{String.Join(", ", bst2.DfsPostOrder())}]");
        }
    }
}