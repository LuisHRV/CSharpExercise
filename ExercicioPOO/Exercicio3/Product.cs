using System.Globalization;

namespace Exercicio3 {
    internal class Product {
        public string Name;
        public double Price;
        public int Amount;

        public double StockValue () {
            return Price * Amount; 
        }

        public void AddAmount(int quantity) {
            Amount = Amount + quantity;
        }

        public void RemoveAmount(int removeQuantity) {
            Amount = Amount - removeQuantity;
        }

        public Product() {
        }

        public override string ToString() {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, {Amount} unidades, Total: $ " 
                + StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
