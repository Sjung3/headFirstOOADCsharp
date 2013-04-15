using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;
        
        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string SerialNumber { get { return serialNumber; } }
        public double Price { get { return price; } set { price = value; } }
        public GuitarSpec Spec { get { return spec; } set { spec = value; } }
    }
}
