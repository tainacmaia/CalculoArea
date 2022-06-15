namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de áreas:");
            var quadrado = new Quadrado();
            quadrado.Lado = 5;
            Console.WriteLine(quadrado.CalcularArea());

            var circulo = new Circulo();
            circulo.Raio = 12;
            Console.WriteLine(circulo.CalcularArea());

            var triangulo = new Triangulo();
            triangulo.Base = 5;
            triangulo.Altura = 12;
            Console.WriteLine(triangulo.CalcularArea());

            var retangulo = new Retangulo();
            retangulo.Base = 5;
            retangulo.Altura = 12;
            Console.WriteLine(retangulo.CalcularArea());
        }
    }
}


