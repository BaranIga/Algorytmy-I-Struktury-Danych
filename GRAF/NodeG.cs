using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    internal class NodeG
    {
        public List<NodeG> neighbors = new List<NodeG>();
        int data;

        public NodeG(int value)
        {
            this.data = value;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
