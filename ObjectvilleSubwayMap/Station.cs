using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    public class Station
    {
        private string name;

        public Station(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public override bool Equals(object obj)
        {
            if (obj is Station)
            {
                Station otherStation = (Station)obj;
                if (otherStation.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return name.ToLower().GetHashCode();
        }
    }
}
