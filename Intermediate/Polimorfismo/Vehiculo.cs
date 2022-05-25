using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancar vehiculo");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerar vehículo");
        }
    }
}
