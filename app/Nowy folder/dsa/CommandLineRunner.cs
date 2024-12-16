using dsa.structures.graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa
{
    public class CommandLineRunner
    {

        public static void Run()
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(2, 4);
            g.AddEdge(4, 3);
            Console.WriteLine(g);
            g.AddEdge(2, 3);
            Console.WriteLine(g);
            Console.WriteLine(g.Degree(2));
            foreach (int a in g.Adj(2))
            {
                Console.Write(a);
            }
        }
    }
}
