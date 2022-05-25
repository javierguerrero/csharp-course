namespace ModificadorSealed
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            this.Cilindrada = cilindrada;
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancar Moto");
        }

        public sealed override void Acelerar()
        {
            Console.WriteLine("Acelerar Moto");
        }
    }

    public class Triciclo : Moto
    {
        public Triciclo(string marca, string modelo, int cilindrada) : base(marca, modelo, cilindrada)
        {
        }

        //public override void Acelerar()
        //{
        //    Console.WriteLine("Acelerar Triciclo");
        //}
    }


}