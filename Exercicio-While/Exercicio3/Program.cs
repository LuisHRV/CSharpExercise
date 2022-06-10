namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Precione 1 para Alcool");
            Console.WriteLine("Precione 2 para Gasolina");
            Console.WriteLine("Precione 3 para Diesel");
            Console.WriteLine("Precione 4 para finalizar pedido");
            Console.Write(":");

            int code = int.Parse(Console.ReadLine());
            int alcohol = 0, gas = 0, diesel = 0;


            while (code != 4) {

                if (code == 1) {
                    alcohol++;
                } else if (code == 2) {
                    gas++;
                } else if (code == 3) {
                    diesel++;
                }else {
                    Console.WriteLine("Numero invalido!");
                }
                code = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"MUITO OBRIGADO!\nALCOOL: {alcohol} \nGASOLINA: {gas}\nDIESEL: {diesel} " );
        }
    }
}