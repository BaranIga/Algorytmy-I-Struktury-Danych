using System.Text;

namespace dsa.structures.graph
{

    /// <summary>
    /// Represents a directed weighted graph structure. Uses <c>int</c> values as vertices.
    /// </summary>
    public class WeightedDigraph
    {

        public int V { get; private set; }
        public int E { get; private set; }
        private readonly List<DirectedEdge>[] _adj;
        private readonly int[] _indegree;

        public WeightedDigraph(int v)
        {
            V = v;
            E = 0;
            _adj = new List<DirectedEdge>[V];
            for (int i = 0; i < V; i++)
            {
                _adj[i] = new List<DirectedEdge> ();
            }
            _indegree = new int[V];
        }

        private void ValidateVertex(int v)
        {
            if (v < 0 || v >= V)
                throw new ArgumentException("vertex " + v + " is not between 0 and " + (V - 1));
        }

        public void AddEdge(DirectedEdge e)
        {
            int v = e.From, w = e.To;
            ValidateVertex(v);
            ValidateVertex(w);
            _adj[v].Add(e);
            E++;
            _indegree[w]++;
        }

        public IEnumerable<DirectedEdge> Adj(int v)
        {
            ValidateVertex(v);
            return _adj[v];
        }

        public int Outdegree(int v)
        {
            ValidateVertex(v);
            return _adj[v].Count;
        }

        public int Indegree(int v)
        {
            ValidateVertex(v);
            return _indegree[v];
        }

        public IEnumerable<DirectedEdge> Edges()
        {
            List<DirectedEdge> edges = new List<DirectedEdge>();
            for (int i = 0; i < V; i++)
            {
                foreach (DirectedEdge e in _adj[i])
                {
                    edges.Add(e);
                }
            }
            return edges;
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Vertices: {V} | Edges: {E}");
            for (int v = 0; v < V; v++)
            {
                sb.Append(v + ": ");
                foreach (DirectedEdge e in _adj[v])
                {
                    sb.Append(e.ToString() + ", ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
