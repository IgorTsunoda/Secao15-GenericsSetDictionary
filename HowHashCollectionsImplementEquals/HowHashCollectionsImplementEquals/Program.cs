using HowHashCollectionsImplementEquals.Entities;

namespace HowHashCollectionsImplementEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Igor");
            set.Add("Maria");

            Console.WriteLine(set.Contains("Maria"));

            //#################################################

            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV", 900.0));
            products.Add(new Product("Notebook", 1200.0));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("TV", 900.0);
            Console.WriteLine(products.Contains(prod));

            Point pointsB  = new Point(3, 4);
            Console.WriteLine(points.Contains(pointsB));

        }
    }
}
