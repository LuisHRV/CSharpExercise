namespace Exercicio2 {
    class Program {
        public static void Main(string[] args) {

            Person personA = new Person();
            Person personB = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            personA.Name = Console.ReadLine();
            Console.Write("Idade: ");
            personA.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            personB.Name = Console.ReadLine();
            Console.Write("Idade: ");
            personB.Age = int.Parse(Console.ReadLine());

            if (personA.Age > personB.Age) {
                Console.WriteLine($"Pessoa mais velha: {personA.Name}");
            }else {
                Console.WriteLine($"Pessoa mais velha: {personB.Name}");
            }
        }
    }
}