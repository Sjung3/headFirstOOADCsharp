using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GuitarApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatEveLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", 
                Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            List<Guitar> guitars = inventory.Search(whatEveLikes);

            if (guitars != null)
            {
                Console.WriteLine("Mamy w magazynie odpowiednią gitarę: ");
                foreach (var g in guitars)
                {
                    GuitarSpec spec = g.Spec;
                    Console.WriteLine(spec.Builder + " model " + spec.Model + " "
                        + spec.Type + " :\n " + spec.BackWood + " - tył i boki,\n " + spec.TopWood
                        + " - góra.\nMożesz ją mieć za " + g.Price + "PLN!\n");    
                }

            }
            else
            {
                Console.WriteLine("Przykro mi, nie znalazlem nic dla Ciebie");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12));
            inventory.AddGuitar("V95612", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12));
        }
    }
}
