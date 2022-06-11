
namespace Exercicio5 {
    internal class Studant {

        public string Name;
        public double FirstNote, SecondNote, ThirdNote;

        public double FinalGrade() {
            return (FirstNote + SecondNote + ThirdNote);
        }
    }
}
