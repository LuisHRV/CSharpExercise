string[] phrase = Console.ReadLine().Split(' ');

double x, y;
x = double.Parse(phrase[0]);
y = double.Parse(phrase[1]);

if ( x == 0.0 && y == 0.0 ) {
    Console.WriteLine("Origem");
}else if ( x > 0.0 && y > 0.0 ) {
    Console.WriteLine("Q1");
}else if ( x > 0.0 && y < 0.0 ) {
    Console.WriteLine("Q2");
}else if ( x < 0.0 && y <0.0 ) {
    Console.WriteLine("Q3");
}else if (x < 0.0 && y > 0.0) {
    Console.WriteLine("Q4");
}