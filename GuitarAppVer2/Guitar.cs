using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public class Guitar : Instrument
    {
        private GuitarSpec spec;
        public Guitar(string serialNumber, double price, GuitarSpec spec) : base(serialNumber, price, spec)
        {
            this.spec = spec;
        }
        
        public GuitarSpec Spec { get { return spec; } set { spec = value; } }
    }
}
