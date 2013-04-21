using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    public class Subway
    {
        private List<Station> stations;
        private List<Connection> connections;

        public Subway()
        {
            this.stations = new List<Station>();
            this.connections = new List<Connection>();
        }

        public bool HasConnection(string station1Name, string station2Name, string lineName)
        {
            Station station1 = new Station(station1Name);
            Station station2 = new Station(station2Name);
            foreach (Connection connection in connections)
            {
                if (connection.LineName.Equals(lineName, StringComparison.OrdinalIgnoreCase))
                {
                    if((connection.Station1.Equals(station1)) && (connection.Station2.Equals(station2)))
                        return true;
                }
            }
            return false;
        }

        public void AddStation(String stationName)
        {
            if(!this.HasStation(stationName))
            {
                Station station = new Station(stationName);
                stations.Add(station);
            }
        }

        public bool HasStation(string stationName)
        {
            return stations.Contains(new Station(stationName));
        }

        public void AddConnection(string station1Name, string station2Name, string connectionName)
        {
            if ((this.HasStation(station1Name)) && (this.HasStation(station2Name)))
            {
                Station station1 = new Station(station1Name);
                Station station2 = new Station(station2Name);
                Connection connection = new Connection(station1, station2, connectionName);
                connections.Add(connection);
                connections.Add(new Connection(station2, station1, connection.LineName));
            }
            else
            {
                throw new KeyNotFoundException("Invalid connection!");
            }
        }
    }
}
