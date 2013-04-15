using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    class Mandolin : Instrument
    {
        private MandolinSpec spec;

        public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {
            this.spec = spec;
        }
        public MandolinSpec Spec { get { return spec; } set { spec = value; } }
    }
}
