namespace Herencia
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
            Console.WriteLine("Arrancar");
        }
    }
}