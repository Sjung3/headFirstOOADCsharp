using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    public class SubwayPrinter
    {
        public void PrintDirections(List<Connection> route)
        {
            Connection connection = (Connection)route[0];
            string currentLine = connection.LineName;
            string previousLine = currentLine;

            Console.WriteLine("Start out at " + connection.Station1.Name + ".");
            Console.WriteLine("Get on the " + currentLine + " heading towards "
                + connection.Station2.Name + ".");
            
            for (int i = 0; i < route.Count; i++)
            {
                connection = (Connection)route[i];
                currentLine = connection.LineName;
                if (currentLine.Equals(previousLine))
                    Console.WriteLine(" Continue past " + connection.Station1.Name + "...");
                else
                {
                    Console.WriteLine("When you get to " + connection.Station1.Name + ", get off the "
                        + previousLine + ".");
                    Console.WriteLine("Switch over to the " + currentLine + ", heading towards"
                        + connection.Station2.Name + ".");
                    previousLine = currentLine;
                }
            }
            Console.WriteLine("Get off at " + connection.Station2.Name + " and enjoy yourself");
        }
    }
}
