namespace dsa.structures.uf
{
    public class QuickFind : IUnionFind
    {

        private int[] _id;

        public QuickFind(int n)
        {
            _id = new int[n];
            for (int i = 0; i < n; i++)
            {
                _id[i] = i;
            }
        }

        public int Find(int p)
        {
            return _id[p];
        }

        public void Union(int p, int q)
        {
            int pId = _id[p];
            int qId = _id[q];
            if (pId == qId)
            {
                return;
            }
            for (int i = 0; i < _id.Length; i++)
            {
                if (_id[i] == pId)
                {
                    _id[i] = qId;
                }
            }
        }
    }
}
