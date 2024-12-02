using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimalistyczne_drzewo_rozpinajace_grafu
{
    internal class Edge
    {
        public NodeG1 start;
        public NodeG1 end;
        public int weight;

        public Edge(NodeG1 start, NodeG1 end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }
    }
}

// edges.OrderBy() <-- sortowanie z using System.linq;
// zapis var list = edges.OrderBy(k=>k.weight).ToList();
