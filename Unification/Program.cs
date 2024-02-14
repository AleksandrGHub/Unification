namespace Unification
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            catalog.RelocateSoldiers();
            catalog.ShowFirstListSoldiers();
            catalog.ShowSecondListSoldiers();
        }
    }
}