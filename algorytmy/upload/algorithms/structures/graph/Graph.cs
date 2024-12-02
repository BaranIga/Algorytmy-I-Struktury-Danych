namespace dsa.structures.graph
{
    internal class Graph
    {

        private int _size;
        private readonly Dictionary<Vertex, List<Vertex>> _adjacencyList;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public Dictionary<Vertex, List<Vertex>> AdjacencyList
        {
            get { return _adjacencyList; }
        }

        public Graph()
        {
            _size = 0;
            _adjacencyList = new Dictionary<Vertex, List<Vertex>>();
        }

        public Graph(Edge edge) : this()
        {
            Add(edge);
        }

        public void Add(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
        }

        public void Add(Edge edge)
        {
            if (!AdjacencyList.ContainsKey(edge.Start))
            {
                AdjacencyList.Add(edge.Start, new List<Vertex>());
            }
            AdjacencyList.GetValueOrDefault(edge.Start).Add(edge.End);

            if (!AdjacencyList.ContainsKey(edge.End))
            {
                AdjacencyList.Add(edge.End, new List<Vertex>());
            }
            AdjacencyList.GetValueOrDefault(edge.End).Add(edge.Start);
        }
    }
}
