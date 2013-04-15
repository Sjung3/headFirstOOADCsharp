using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DougDogsDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            BarkRecognizer recognizer = new BarkRecognizer(door);

            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));

            Console.WriteLine("Fido barks to go outside");
            recognizer.Recognize(new Bark("rowlf"));
            //remote.PressButton();

            Console.WriteLine("\nFido has gone outside");
            //remote.PressButton();

            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {}

            Console.WriteLine("\nFido's all done");
            Console.WriteLine("... but he's stuck outside");
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking");
            recognizer.Recognize(smallDogBark);

            Console.WriteLine("Fido starts barking.");
            recognizer.Recognize(new Bark("rooowlf"));
                //Console.WriteLine("... so Gina grabs the remote control.");
                //remote.PressButton();
              
            Console.WriteLine("\nFido's back inside");
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            { }
        }
    }
}
