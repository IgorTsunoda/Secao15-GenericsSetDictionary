using GetHashCode_e_Equals.Entities;

namespace GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Igor";

            Console.WriteLine(a.Equals(b));

            string g = "Fernanda";
            string h = "Torresminho";

            Console.WriteLine(g.GetHashCode());
            Console.WriteLine(h.GetHashCode());

            //GetHashCode e Equals personalizados.

            Client c1 = new Client {Name="Maria", Email="Maria@gmail.com" };
            Client c2 = new Client { Name = "Fernanda", Email = "Fernanda@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            //Console.WriteLine(a == b); isso, não é a mesma coisa que um equals, aqui,
            //ele esta comparando se o endereço do ponteiro é o mesmo. portanto o resultado deveria ser falso

        }
    }
}
