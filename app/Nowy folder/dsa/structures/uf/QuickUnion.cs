namespace dsa.structures.uf
{
    public class QuickUnion : IUnionFind
    {

        private int[] _parent;

        public QuickUnion(int n)
        {
            _parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                _parent[i] = i;
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
            int rootP = _parent[p];
            int rootQ = _parent[q];
            if (rootP == rootQ)
            {
                return;
            }
            _parent[rootP] = rootQ;
        }
    }
}
