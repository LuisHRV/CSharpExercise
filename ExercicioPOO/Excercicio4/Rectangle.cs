namespace Excercicio4 {
    internal class Rectangle {

        public double Width, Height;
        
        public double Area() {
            return Height * Width;
        }
        public double Perimeter() {
            return 2 * (Width + Height);
        }
        public double Diagonal() {
            return Math.Sqrt(Height * Height + Width * Width);
        }

    }
}
