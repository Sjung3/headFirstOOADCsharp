using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    class SubwayTester
    {
        public static void Main2(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: SubwayTester [startStation] [endStation]");
                Environment.Exit(-1);
            }

            try
            {
                SubwayLoader loader = new SubwayLoader();
                Subway objectville = loader.LoadFromFile("ObjectvilleSubway.txt");

                if (!objectville.HasStation(args[0]))
                {
                    Console.WriteLine(args[0] + " is not a station in Objectville.");
                    Environment.Exit(-1);
                }
                else if (!objectville.HasStation(args[1]))
                {
                    Console.WriteLine(args[1] + " is not a station in Objectville.");
                    Environment.Exit(-1);
                }

                List<Connection> route = objectville.GetDirections(args[0], args[1]);
                SubwayPrinter printer = new SubwayPrinter();
                printer.PrintDirections(route);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
