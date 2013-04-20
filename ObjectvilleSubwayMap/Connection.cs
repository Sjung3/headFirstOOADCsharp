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

        public Station Station1 { get; }
        public Station Station2 { get; }
        public string LineName { get; }
    }
}
