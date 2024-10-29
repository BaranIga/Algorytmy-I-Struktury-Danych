using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praca_domowa_02
{
    internal class Node
    {
        public int data;
        public Node prev;
        public Node next;
        public Node(int liczba)
        {
            this.data = liczba;
        }

    }
}
