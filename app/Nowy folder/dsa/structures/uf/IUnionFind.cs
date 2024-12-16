namespace dsa.structures.uf
{
    public interface IUnionFind
    {
        int Find(int p);
        void Union(int p, int q);
    }
}
