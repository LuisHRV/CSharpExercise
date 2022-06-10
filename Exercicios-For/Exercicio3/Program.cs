namespace Exercicio3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qauntos numeros voce vai colocar?");
            int numb = int.Parse(Console.ReadLine());
            int inValue = 0, outValue = 0, addValue;

            for (int i = 0; i < numb; i++) {

                Console.Write("Adicione o valor: ");
                addValue = int.Parse(Console.ReadLine());

                if (addValue >= 10 && addValue <= 20) {

                    inValue++;

                } else {

                    outValue++;

                }
            }
            Console.WriteLine($"{inValue} in \n{outValue} out");
        }
    }
}