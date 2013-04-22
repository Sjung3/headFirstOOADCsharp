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
        private Dictionary<Station, List<Station>> network;

        public Subway()
        {
            this.stations = new List<Station>();
            this.connections = new List<Connection>();
            this.network = new Dictionary<Station, List<Station>>();
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

                AddToNetwork(station1, station2);
                AddToNetwork(station2, station1);
            }
            else
            {
                throw new KeyNotFoundException("Invalid connection!");
            }
        }

        private void AddToNetwork(Station station1, Station station2)
        {
            if (network.ContainsKey(station1))
            {
                List<Station> connectingStations = (List<Station>)network[station1];
                if (!connectingStations.Contains(station2))
                    connectingStations.Add(station2);
            }
            else
            {
                List<Station> connectingStations = new List<Station>();
                connectingStations.Add(station2);
                network.Add(station1, connectingStations);
            }
        }

        public List<Connection> GetDirections(string startStationName, string endStartionName)
        {
            if (!this.HasStation(startStationName) || (!this.HasStation(endStartionName)))
            {
                throw new KeyNotFoundException("Stations enterered do not exists on this subway");
            }

            Station start = new Station(startStationName);
            Station end = new Station(endStartionName);

            List<Connection> route = new List<Connection>();
            List<Station> reachableStations = new List<Station>();
            Dictionary<Station, Station> previousStation = new Dictionary<Station, Station>();

            List<Station> neighbours = (List<Station>)network[start];

            foreach (var station in neighbours)
            {
                if (station.Equals(end))
                {
                    route.Add(GetConnection(start, end));
                    return route;
                }
                else
                {
                    reachableStations.Add(station);
                    previousStation.Add(station, start);
                }
            }

            List<Station> nextStations = new List<Station>();
            nextStations.AddRange(neighbours);

            Station currentStation = start;
            
            //searchLoop
            for (int i = 0; i < stations.Count; i++)
            {
                List<Station> tmpNextStations = new List<Station>();
                foreach (var station in nextStations)
                {
                    reachableStations.Add(station);
                    currentStation = station;

                    List<Station> currentNeighbours = (List<Station>)network[currentStation];

                    foreach (var neighbor in currentNeighbours)
                    {
                        if (neighbor.Equals(end))
                        {
                            reachableStations.Add(neighbor);
                            previousStation.Add(neighbor, currentStation);
                            goto loopEnd;
                        }
                        else if (!reachableStations.Contains(neighbor))
                        {
                            reachableStations.Add(neighbor);
                            tmpNextStations.Add(neighbor);
                            previousStation.Add(neighbor, currentStation);
                        }
                    }
                }
                nextStations = tmpNextStations;
            }

        loopEnd:

            bool keepLooping = true;
            Station keyStation = end;

            while (keepLooping)
            {
                Station station = (Station)previousStation[keyStation];
                route.Add(GetConnection(station, keyStation));
                if (start.Equals(station))
                    keepLooping = false;
                keyStation = station;
            }
            return route;
        }

        private Connection GetConnection(Station station1, Station station2)
        {
            foreach (var connection in connections)
            {
                Station one = connection.Station1;
                Station two = connection.Station2;
                if((station1.Equals(one) && (station2.Equals(two))))
                    return connection;           
            }
            return null;
        }
    }
}
