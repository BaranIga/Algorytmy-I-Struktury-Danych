using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace TreeView_Program
{
    internal class BTS
    {
        public NodeT root { get; private set; }

        public BTS()
        {
            root = null;
        }

        public void Add(int liczba)
        {
            NodeT newNode = new NodeT(liczba); 

            if (root == null)
            {
                root = newNode;
                return;
            }

            NodeT temp = root;
            NodeT parent = null;

            while (temp != null)
            {
                parent = temp;
                if (liczba < temp.data)
                {
                    temp = temp.left_child; 
                }
                else if (liczba > temp.data)
                {
                    temp = temp.right_child; 
                }
                else
                { 
                    return;
                }
            }

            if (liczba < parent.data)
                parent.left_child = newNode; 
            else
                parent.right_child = newNode; 
        }

        public void FillTreeView(NodeT node, TreeNode treeNode)
        {
            if (node == null) return;


            TreeNode newTreeNode = new TreeNode(node.data.ToString());
            if (treeNode == null)
            {
                treeNode = newTreeNode;
            }
            else
            {
                treeNode.Nodes.Add(newTreeNode); 
            }

            FillTreeView(node.left_child, newTreeNode);
            FillTreeView(node.right_child, newTreeNode);
        }
    }
}
