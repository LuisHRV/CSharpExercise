namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite as coordenadas: ");

            string[] phrase = Console.ReadLine().Split(' ');

            int x, y;
            x = int.Parse(phrase[0]);
            y = int.Parse(phrase[1]);

            while (x != 0 && y != 0) {

                if (x > 0 && y > 0) {

                    Console.WriteLine("Primeiro Quadrante");

                } else if (x < 0 && y > 0) {

                    Console.WriteLine("Segundo Quadrante");

                } else if (x < 0 && y < 0) {

                    Console.WriteLine("Terceito Quadrante");

                } else {

                    Console.WriteLine("Quarto Quadrante");
                    
                }
                Console.Write("Digite as coordenadas: ");

                phrase = Console.ReadLine().Split(' ');

                x = int.Parse(phrase[0]);
                y = int.Parse(phrase[1]);
            }
        }
    }
}