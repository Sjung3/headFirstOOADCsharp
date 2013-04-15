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

            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("builder", Builder.GIBSON.ToString());
            properties.Add("backWood", Wood.MAPLE.ToString());

            InstrumentSpec clientSpec = new InstrumentSpec(properties);

            #region old
            //GuitarSpec whatEveLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", 
            //    Type.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            //MandolinSpec whatEveWants = new MandolinSpec(Builder.FENDER, "Major", Type.ACOUSTIC, Wood.ALDER, Wood.ALDER, Style.A);
            ////List<Guitar> guitars = inventory.Search(whatEveLikes);
            //List<Mandolin> mandolins = inventory.Search(whatEveWants);
            #endregion

            List<Instrument> matchingInstrument = inventory.Search(clientSpec);

            #region old
            //if (mandolins != null)
            //{
            //    Console.WriteLine("Mamy w magazynie odpowiedni instrument: ");
            //    foreach (var m in mandolins)
            //    {
            //        MandolinSpec spec = m.Spec;
            //        Console.WriteLine(spec.Builder + " model " + spec.Model + " "
            //            + spec.Type + " :\n " + spec.BackWood + " - tył i boki,\n " + spec.TopWood
            //            + " - góra.\nMożesz ją mieć za " + m.Price + "PLN!\n");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Przykro mi, nie znalazlem nic dla Ciebie");
            //}
            #endregion

            if (matchingInstrument.Count > 0)
            {
                Console.WriteLine("You might like these instruments:");
                foreach (var instrument in matchingInstrument)
                {
                    InstrumentSpec spec = instrument.Spec;
                    Console.WriteLine("We have a " + spec["instrumentType"] + " with following properties:");
                    foreach (var propertyName in spec.Properties.Keys)
                    {
                        if (propertyName.Equals("instrumentType"))
                            continue;
                        Console.WriteLine(" " + propertyName + ": " + spec[propertyName]);
                    }
                    Console.WriteLine("You can have this " + spec["instrumentType"] + " for $" + instrument.Price + "\n---");
                }
            }
            else
            {
                Console.WriteLine("Sorry, we have nothing for you");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties["instrumentType"] = InstrumentType.Guitar.ToString();
            properties["builder"] = Builder.COLLINGS.ToString();
            properties["model"] = "CJ";
            properties["type"] = Type.ACOUSTIC.ToString();
            properties["numStrings"] = "6";
            properties["topWood"] = Wood.INDIAN_ROSEWOOD.ToString();
            properties["backWood"] = Wood.SITKA.ToString();
            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));

            properties["builder"] = Builder.MARTIN.ToString();
            properties["model"] = "D-18";
            properties["topWood"] = Wood.MAHOGANY.ToString();
            properties["backWood"] = Wood.ALDER.ToString();
            inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties));

            properties["builder"] = Builder.FENDER.ToString();
            properties["model"] = "Stratocastor";
            properties["type"] = Type.ELECTRIC.ToString();
            properties["topWood"] = Wood.ALDER.ToString();
            properties["backWood"] = Wood.ALDER.ToString();
            inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties));
            inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties));

            properties["builder"] = Builder.GIBSON.ToString();
            properties["model"] = "Les Paul";
            properties["topWood"] = Wood.MAPLE.ToString();
            properties["backWood"] = Wood.MAPLE.ToString();
            inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties));

            properties["model"] = "SG '61 Reissue";
            properties["topWood"] = Wood.MAHOGANY.ToString();
            properties["backWood"] = Wood.MAHOGANY.ToString();
            inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(properties));

            properties["instrumentType"] = InstrumentType.Mandolin.ToString();
            properties["type"] = Type.ACOUSTIC.ToString();
            properties["model"] = "F-5G";
            properties["backWood"] = Wood.MAPLE.ToString();
            properties["topWood"] = Wood.MAPLE.ToString();
            properties.Remove("numStrings");
            inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(properties));

            properties["instrumentType"] = InstrumentType.Banjo.ToString();
            properties["model"] = "RB-3 Wreath";
            properties.Remove("topWood");
            properties["numStrings"] = "5";
            inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(properties));
        }
    }
}
