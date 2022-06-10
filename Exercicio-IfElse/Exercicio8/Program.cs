using System.Globalization;

double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salary == 0 || salary <= 2000.00) {

    Console.WriteLine("Isento");

} else if (salary <= 3000.00) {

    double tax = (salary -2000.00) * 0.08;
    Console.WriteLine($"R$ {tax}");

} else if (salary <= 4500.00) {

    double tax = (salary - 3000.00) * 0.18 + 1000.00 * 0.08;
    Console.WriteLine($"R$ {tax}");

} else if (salary >= 4500.00) {

    double tax = (salary - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
    Console.WriteLine($"R$ {tax}");

}
