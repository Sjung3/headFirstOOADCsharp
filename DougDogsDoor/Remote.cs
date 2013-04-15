using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace DougDogsDoor
{
    public class Remote
    {
        private DogDoor door;
        static System.Timers.Timer timer;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
                door.Close();
            else
            {
                door.Open();
                //ThreadStart ts = new ThreadStart(TimeCallback);
                //Thread thread = new Thread(ts);
                //thread.Start();

                
            }
        }

        private void TimeCallback()
        {
            Thread.Sleep(5000);
            door.Close();
        }
    }
}
