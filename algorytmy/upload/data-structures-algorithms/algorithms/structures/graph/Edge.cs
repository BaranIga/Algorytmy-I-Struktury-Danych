namespace dsa.structures.graph
{
    internal class Edge
    {

        public Vertex Start { get; }
        public Vertex End { get; }
        public int Weight { get; set; }

        public Edge(Vertex start, Vertex end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }
    }
}
