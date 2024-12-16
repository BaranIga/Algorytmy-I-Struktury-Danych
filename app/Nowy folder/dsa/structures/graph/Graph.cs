using System.Text;

namespace dsa.structures.graph
{
    /// <summary>
    /// Represents an undirected unweighted graph data structure. Uses <c>int</c> values as vertices.
    /// </summary>
    public class Graph
    {
        private readonly int _v;
        private int _e;
        private readonly List<int>[] _adj;

        public Graph(int v)
        {
            if (v < 0)
            {
                throw new ArgumentException("The number of vertices cannot be negative.");
            }
            _v = v;
            _e = 0;
            _adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                _adj[i] = new List<int>();
            }
        }

        public int V()
        {
            return _v;
        }

        public int E()
        {
            return _e;
        }

        private void ValidateVertex(int v)
        {
            if (v < 0 || v >= _v)
            {
                throw new ArgumentException(String.Format($"Vertex {v} is not between 0 and {_v}"));
            }
        }

        public void AddEdge(int v, int w)
        {
            ValidateVertex(v);
            ValidateVertex(w);
            _adj[v].Add(w);
            _adj[w].Add(v);
            _e++;
        }

        public IEnumerable<int> Adj(int v)
        {
            ValidateVertex(v);
            return _adj[v];
        }

        public int Degree(int v)
        {
            ValidateVertex(v);
            return _adj[v].Count;
        }

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"vertices: {_v}, edges: {_e}");
            for (int v = 0; v < _v; v++)
            {
                sb.Append(v + " --> ");
                foreach (int w in _adj[v])
                {
                    sb.Append(w + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
