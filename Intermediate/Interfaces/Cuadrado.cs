using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IPieza
    {
        readonly decimal lado;
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public decimal Area()
        {
            return lado * lado;
        }

        public decimal Perimetro()
        {
            return lado * 4;
        }
    }
}
