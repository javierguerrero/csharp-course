using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public class Test
    {
        public void Execute()
        {
            Acutangulo acutangulo = new Acutangulo();
            Escaleno escaleno = new Escaleno();

            acutangulo.Area();
            escaleno.Area();

            escaleno.CalcularAreaTrianguloConHipotenusa(2, 5);
            acutangulo.CalcularAreaTrianguloConHipotenusa(2, 5);
        }



    }
}
