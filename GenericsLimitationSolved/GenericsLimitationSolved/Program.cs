using GenericsLimitationSolved.Entities;
using GenericsLimitationSolved.Services;
using System.Globalization;

namespace GenericsLimitationSolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the number of products: ");
            int N = 0;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = Console.ReadLine();
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list);
            Console.WriteLine("Most Expensive: ");
            Console.WriteLine(p);
        }
    }
}