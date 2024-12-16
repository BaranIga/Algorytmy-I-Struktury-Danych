namespace dsa.structures.graph
{
    /// <summary>
    /// Represents an undirected weighted graph data structure. Uses <c>int</c> values as vertices.
    /// </summary>
    public class WeightedGraph
    {

        private int _v;
        private int _e;
        private List<Edge>[] _adj;

        public WeightedGraph(int v)
        {
            if (v < 0)
            {
                throw new ArgumentException("The number of vertices cannot be negative.");
            }
            _v = v;
            _e = 0;
            _adj = new List<Edge>[v];
            for (int i = 0; i < v; i++)
            {
                _adj[i] = new List<Edge>();
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

        public void AddEdge(Edge e)
        {
            int v = e.Either();
            int w = e.Other(v);
            ValidateVertex(v);
            ValidateVertex(w);
            _adj[v].Add(e);
            _adj[w].Add(e);
            _e++;
        }

        public IEnumerable<Edge> Adj(int v)
        {
            ValidateVertex(v);
            return _adj[v];
        }

        public int Degree(int v)
        {
            ValidateVertex(v);
            return _adj[v].Count;

        }
    }
}
