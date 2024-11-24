using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRAF
{
    internal class Graf
    {
        List<NodeG> nodes = new List<NodeG>();

        public void AddNode(NodeG node)
        {
            if (!nodes.Contains(node))
            {
                nodes.Add(node);
            }
        }

        public List<NodeG> Wszerz(NodeG start)
        {
            var odwiedzane = new List<NodeG>()
            {
                start
            };

            for (int i = 0; i < odwiedzane.Count; i++)
            {
                var tmp = odwiedzane[i];
                for (int j = 0; j < tmp.neighbors.Count; j++)
                {
                    if (!odwiedzane.Contains(tmp.neighbors[j]))
                    {
                        odwiedzane.Add(tmp.neighbors[j]);
                    }
                }
            }

            return odwiedzane;
        }


        public List<NodeG> wzdluz(NodeG start, List<NodeG> odwiedzone = null)
        {
            if (odwiedzone == null)
            {
                odwiedzone = new List<NodeG>();
            }

            if (!odwiedzone.Contains(start))
            {
                odwiedzone.Add(start);

                for (int i = 0; i < start.neighbors.Count; i++)
                {
                    var neighbor = start.neighbors[i];
                    if (!odwiedzone.Contains(neighbor))
                    {
                        wzdluz(neighbor, odwiedzone);
                    }
                }
            }

            return odwiedzone;
        }
    }
}
