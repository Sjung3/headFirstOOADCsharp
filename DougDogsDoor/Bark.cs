using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DougDogsDoor
{
    public class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            // TODO: Complete member initialization
            this.sound = sound;
        }

        public string Sound { get { return sound; } }

    }
}
