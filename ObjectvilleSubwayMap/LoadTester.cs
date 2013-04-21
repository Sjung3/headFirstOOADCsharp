using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectvilleSubwayMap
{
    class LoadTester
    {
        public static void Main(string[] args)
        {
            try
            {
                SubwayLoader loader = new SubwayLoader();
                Subway objectville = loader.LoadFromFile("ObjectvilleSubway.txt");

                Console.WriteLine("Testing stations...");
                if (objectville.HasStation("Head First Lounge") &&
                        objectville.HasStation("Objectville Diner") &&
                        objectville.HasStation("Objectville Diner"))
                {
                    Console.WriteLine("... station test PASSED successfully.");
                }
                else
                {
                    Console.WriteLine("... station test FAILED.");
                    Environment.Exit(-1);
                }

                Console.WriteLine("\nTesting connections...");
                if (objectville.HasConnection("HeadFirstLabs", "LSP Lane", "Booch Line") &&
                    objectville.HasConnection("SRP Square", "OCP Orchard", "Liskov Line") &&
                    objectville.HasConnection("OOA&D Oval", "Head First Lounge", "Gamma Line"))
                {
                    Console.WriteLine("... conncetions test PASSED succesfully.");
                }
                else
                {
                    Console.WriteLine("... connections test FAILED.");
                    Environment.Exit(-1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
