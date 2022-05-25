﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {
            this.Cilindrada = cilindrada;
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Moto acelerar");
        }
    }
}
