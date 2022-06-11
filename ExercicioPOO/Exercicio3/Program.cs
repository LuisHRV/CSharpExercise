using System.Globalization;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {

            Product p = new Product();

            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome:");
            p.Name = Console.ReadLine();

            Console.Write("Preço:");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade:");
            p.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qty = int.Parse(Console.ReadLine());
            p.AddAmount(qty);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
            int remqty = int.Parse(Console.ReadLine());
            p.RemoveAmount(remqty);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();
        }
    }
}