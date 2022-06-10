namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a senha:");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Acesso Negado");
                Console.Write("Digite a senha:");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}