using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    class Inventory
    {
        private LinkedList<Guitar> guitars;

        public Inventory()
        {
            guitars = new LinkedList<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec) 
        {
            var guitar = new Guitar(serialNumber, price, spec);
            guitars.AddLast(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                    return guitar;
            }
            return null;
        }

        public List<Guitar> Search (GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (var guitar in guitars)
            {
                GuitarSpec guitarSpec = guitar.Spec;
                if (guitar.Spec.Matches(searchSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
