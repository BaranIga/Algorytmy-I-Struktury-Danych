using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class NodeT
    {
        public NodeT parent;
        public NodeT left_child;
        public NodeT right_child;
        public int data;

        public NodeT(int liczba)
        {
            this.data = liczba;
        }
    }
}

