using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Test
    {
        public void Execute()
        {
            IPieza triangulo = new TrianguloRectangulo(3, 4);
            IPieza cuadrado = new Cuadrado(4);

            Console.WriteLine($"El área del cuadrado es {cuadrado.Area()} y su perímetro {cuadrado.Perimetro()}");
            Console.WriteLine($"El área del triángulo es {triangulo.Area()} y su perímetro {triangulo.Perimetro()}");
        }
    }
}
