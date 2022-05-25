namespace Interfaces
{
    public class TrianguloRectangulo : IPieza
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal Hipotenusa { get; set; }

        public TrianguloRectangulo(decimal ladoA, decimal ladoB)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.Hipotenusa = CalcularHipotenusa(ladoA, ladoB);
        }

        private decimal CalcularHipotenusa(decimal ladoA, decimal ladoB)
        {
            return Convert.ToDecimal(Math.Sqrt((double)(ladoA * ladoA + ladoB * ladoB)));
        }

        public decimal Area()
        {
            return LadoA * LadoB / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}