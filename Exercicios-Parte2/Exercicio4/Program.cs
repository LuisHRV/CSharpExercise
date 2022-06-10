using System;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            string[] value = Console.ReadLine().Split(' ');
            int initHour = int.Parse(value[0]);
            int endHour = int.Parse(value[1]);

            int duration;
            if (initHour < endHour) {
                duration = endHour - initHour;
            } else {
                duration = 24 - initHour + endHour;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }
    }
}