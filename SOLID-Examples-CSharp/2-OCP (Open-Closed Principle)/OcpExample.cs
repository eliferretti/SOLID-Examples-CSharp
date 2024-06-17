namespace SOLID_Examples_CSharp.OCP
{
    public class OcpExample
    {
        // A classe abstrata Shape define um método para calcular a área
        public abstract class Shape
        {
            public abstract double Area();
        }

        // A classe Circle herda de Shape e implementa o cálculo da área de um círculo
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double Area() => Math.PI * Radius * Radius;
        }

        // A classe Rectangle herda de Shape e implementa o cálculo da área de um retângulo
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area() => Width * Height;
        }
    }
}
