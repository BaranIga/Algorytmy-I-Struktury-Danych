namespace dsa.structures.uf
{
    public class UnionFind : IUnionFind
    {

        private int[] _parent;
        private int[] _rank;

        public UnionFind(int n)
        {
            _parent = new int[n];
            _rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                _parent[i] = i;
                _rank[i] = 0;
            }
        }

        public int Find(int p)
        {
            while (p != _parent[p])
            {
                _parent[p] = _parent[_parent[p]]; // <-- path compression
                p = _parent[p];
            }
            return p;
        }

        public void Union(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ)
            {
                return;
            }
            if (_rank[rootP] < _rank[rootQ])
            {
                _parent[rootP] = rootQ;
            }
            else if (_rank[rootP] > _rank[rootQ])
            {
                _parent[rootQ] = rootP;
            }
            else
            {
                _parent[rootP] = rootQ;
                _rank[rootQ]++;
            }
        }
    }
}
