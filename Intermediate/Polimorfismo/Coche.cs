namespace Polimorfismo
{
    public class Coche : Vehiculo
    {
        public string Traccion { get; set; }
        public Coche(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            this.Traccion = traccion;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerar coche");
        }
    }
}