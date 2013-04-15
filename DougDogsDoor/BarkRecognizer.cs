using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DougDogsDoor
{
    class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(string bark)
        {
            Console.WriteLine("Bark Recognizer: I've heard '" + bark + "'");
            door.Open();
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine("Bark Recognizer: I've heard '" + bark.Sound + "'");
            List<Bark> allowedBarks = door.AllowedBarks;
            foreach (var allowedBark in allowedBarks)
            {
                if ((allowedBark.Sound).Equals(bark.Sound))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed");
        }
    }
}
