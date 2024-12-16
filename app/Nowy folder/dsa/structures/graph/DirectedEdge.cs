namespace dsa.structures.graph
{
    /// <summary>
    /// Represents a directed weighted edge of a graph. Uses <c>int</c> values as vertices.
    /// </summary>
    public class DirectedEdge
    {

        private int _from;
        private int _to;
        private double _weight;

        public int From {
            get {
                return _from;
            }
            private set {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _from = value;
            }
        }

        public int To {
            get
            {
                return _to;
            }
            private set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _to = value;
            }
        }

        public double Weight {
            get { return  _weight; }
            set { _weight = value; }
        }

        public DirectedEdge(int from, int to, double weight)
        {
            From = from;
            To = to;
            _weight = weight;
        }



        public override string ToString()
        {
            return $"{From}->{To} ({Weight:F2})";
        }

        public override bool Equals(object? obj)
        {
            return obj is DirectedEdge edge &&
                   From == edge.From &&
                   To == edge.To &&
                   Math.Abs(Weight - edge.Weight) < 0.0000001;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(From, To, Weight);
        }
    }
}
