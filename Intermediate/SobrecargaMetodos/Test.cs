using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    public class Test
    {
        public void Execute()
        {
            var sobrecarga = new Sobrecarga();
            sobrecarga.Suma(10,10);
        }
    }
}
