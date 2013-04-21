using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    public class Connection
    {
        private Station station1, station2;
        private string lineName;

        public Connection(Station station1, Station station2, string lineName)
        {
            this.station1 = station1;
            this.station2 = station2;
            this.lineName = lineName;
        }

        public Station Station1 { get { return station1; } }
        public Station Station2 { get { return station2; } }
        public string LineName { get { return lineName; } }
    }
}
