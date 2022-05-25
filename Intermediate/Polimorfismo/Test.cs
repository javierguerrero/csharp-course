using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Test
    {
        public void Execute() 
        {
            Coche coche1 = new Coche("opel", "vectra", "2 ruedas");
            Moto moto1 = new Moto("kawasaki", "ninja", 1000);

            moto1.Arrancar();
            coche1.Arrancar();

            moto1.Acelerar();
            coche1.Acelerar();
        }
    }
}
