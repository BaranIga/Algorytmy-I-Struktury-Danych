namespace dsa.structures.graph
{
    public class Edge
    {
        private int _v;
        private int _w;

        public Edge(int v, int w)
        {
            _v = v;
            _w = w;
        }

        public int Either()
        {
            return _v;
        }

        public int Other(int v)
        {
            if (v == _v)
            {
                return _w;
            }
            else
            {
                return _v;
            }
        }
    }
}
