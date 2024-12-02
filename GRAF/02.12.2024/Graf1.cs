using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace minimalistyczne_drzewo_rozpinajace_grafu
{
    internal class Graf1
    {
        public List<NodeG1> nodes;
        public List<Edge> edges;

        public Graf1()
        {
            nodes = new List<NodeG1>();
            edges = new List<Edge>();
        }

        public void Add(Edge k)
        {
            if (!nodes.Contains(k.start))
            {
                nodes.Add(k.start);
            }
            if (!nodes.Contains(k.end))
            {
                nodes.Add(k.end);
            }

            edges.Add(k);
        }

        public void AddEdge(int startData, int endData, int weight)
        {
            NodeG1 start = nodes.FirstOrDefault(n => n.data == startData) ?? new NodeG1(startData);
            NodeG1 end = nodes.FirstOrDefault(n => n.data == endData) ?? new NodeG1(endData);

            Add(new Edge(start, end, weight));
        }


        public int ileNowychWezlow(Edge k)
        {
            int count = 0;
            if (!nodes.Contains(k.start))
                count++;
            if (!nodes.Contains(k.end))
                count++;
            return count;
        }


        public void Join(Graf1 g1)
        {
            foreach (var node in g1.nodes)
            {
                if (!nodes.Contains(node))
                    nodes.Add(node);
            }

            foreach (var edge in g1.edges)
            {
                if (!edges.Contains(edge))
                    edges.Add(edge);
            }
        }

        public Graf1 AlgorytmKruskala()
        {
            List<Graf1> tmp = new List<Graf1>();

            var list = edges.OrderBy(k => k.weight).ToList();

            foreach (var node in tmp)
            {
                tmp.Add(node);
            }

            var mst = new Graf1();

            foreach (var edge in list)
            {
                Graf1 tree1 = null, tree2 = null;

                foreach (var tree in tmp)
                {
                    if (tree.nodes.Contains(edge.start)) tree1 = tree;
                    if (tree.nodes.Contains(edge.end)) tree2 = tree;
                }

                if (tree1 != null && tree2 != null && tree1 == tree2)
                {
                    continue;
                }
                else if (tree1 != null && tree2 != null && tree1 != tree2)
                {
                    tree1.Join(tree2);
                    tmp.Remove(tree2);
                    mst.Add(edge);
                }
                else if (tree1 != null || tree2 != null)
                {
                    var existingTree = tree1 ?? tree2;
                    existingTree.nodes.Add(tree1 == null ? edge.start : edge.end);
                    mst.Add(edge);
                }
                else
                {
                    var newTree = new Graf1();
                    newTree.Add(edge);
                    tmp.Add(newTree);
                    mst.Add(edge);
                }
            }

            return mst;
            /*
            public void AddNode(int data)
            {
                nodes.Add(new NodeG1(data));
            }

            public void AddEdge(int data) {

            void Add(Edge k)
            {

            }
            int ileNowychWezlow(Edge k)
            {
                int count = 0;
                if ()
                {

                }

            }

            void Join(Graf1 g1)
            {

                for (int i = 0; i < g1.edges.Count; i++)
                {
                    this.Add(g1.edges[i]);
                }
            }
            */
        }
    }
}
