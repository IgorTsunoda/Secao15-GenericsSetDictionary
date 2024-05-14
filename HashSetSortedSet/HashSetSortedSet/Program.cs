namespace HashSetSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach(string hash in set)
            {
                Console.WriteLine(hash);
            }

            //SortedSet

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>(a) { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("SortedSet:");
            PrintCollection(a);

            // union
            SortedSet<int> conjunto = new SortedSet<int>(a);
            conjunto.UnionWith(b);
            Console.WriteLine("Union:");
            PrintCollection(conjunto);

            // intersection
            SortedSet<int> intersection = new SortedSet<int>(a);
            intersection.IntersectWith(b);
            Console.WriteLine("Intersection:");
            PrintCollection(intersection);

            SortedSet<int> difference = new SortedSet<int>(a);
            difference.ExceptWith(b);
            Console.WriteLine("Difference:");
            PrintCollection(difference);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
             foreach(T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
