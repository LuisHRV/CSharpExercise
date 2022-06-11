using System.Globalization;

namespace Exercicio2 {
    internal class Hotel {
        public string Name { get; set; }
        public string Email { get; set; }
        public Hotel (string name, string email) {
            Name = name;
            Email = email;
        }
        public override string ToString() {
            return Name + ", " + Email;
        }
    }
}
