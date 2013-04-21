using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    public class SubwayLoader
    {
        private Subway subway;

        public SubwayLoader()
        {
            this.subway = new Subway();
        }

        public Subway LoadFromFile(string subwayFile)
        {
            StreamReader reader = File.OpenText(subwayFile);
            LoadStations(subway, reader);

            string lineName = reader.ReadLine();

            while ((lineName != null) && (lineName.Length > 0))
            {
                LoadLine(subway, reader, lineName);
                lineName = reader.ReadLine();
            }

            return subway;

        }

        private void LoadLine(Subway subway, StreamReader reader, string lineName)
        {
            string station1Name, station2Name;
            station1Name = reader.ReadLine();
            station2Name = reader.ReadLine();

            while ((station2Name != null) && (station2Name.Length > 0))
            {
                subway.AddConnection(station1Name, station2Name, lineName);
                station1Name = station2Name;
                station2Name = reader.ReadLine();
            }
        }

        private void LoadStations(Subway subway, StreamReader reader)
        {
            string currentLine;
            currentLine = reader.ReadLine();

            while (currentLine.Length > 0)
            {
                subway.AddStation(currentLine);
                currentLine = reader.ReadLine();
            }
        }
    }
}
