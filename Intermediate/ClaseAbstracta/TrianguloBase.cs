namespace ClaseAbstracta
{
    public abstract class TrianguloBase
    {
        public abstract decimal Perimetro();
        public abstract decimal Area();
        public double CalcularAreaTrianguloConHipotenusa(int lado, int hipotenusa)
        {
            double ladoB = Math.Sqrt(Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(lado, 2)));
            return lado * ladoB / 2;
        }
    }

    public class Escaleno : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }

    public class Acutangulo : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}