
namespace dsa.structures.graph
{
    internal class Vertex
    {

        private readonly int _data;
        public int Data
        {
            get { return _data; }
        }


        public Vertex(int data)
        {
            _data = data;
        }

        public override bool Equals(object? obj)
        {
            return obj is Vertex vertex &&
                   Data == vertex.Data;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Data);
        }
    }
}
