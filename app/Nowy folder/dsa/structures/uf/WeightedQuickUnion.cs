namespace dsa.structures.uf
{
    public class WeightedQuickUnion : IUnionFind
    {

        private int[] _parent;
        private int[] _size;

        public WeightedQuickUnion(int n)
        {
            _parent = new int[n];
            _size = new int[n];
            for (int i = 0; i < n; i++)
            {
                _parent[i] = i;
                _size[i] = 1;
            }
        }

        public int Find(int p)
        {
            while (p != _parent[p])
            {
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

            if (_size[rootP] < _size[q])
            {
                _parent[rootP] = rootQ;
                _size[rootQ] += _size[rootP];
            }
            else
            {
                _parent[rootQ] = rootP;
                _size[rootP] += _size[rootQ];
            }
        }
    }
}
