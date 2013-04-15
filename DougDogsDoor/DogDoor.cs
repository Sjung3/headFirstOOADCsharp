using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DougDogsDoor
{
    public class DogDoor
    {
        private bool open;
        private System.Timers.Timer timer;

        private List<Bark> allowedBarks;

        public DogDoor()
        {
            this.open = false;
            allowedBarks = new List<Bark>();
        }

        public void Open()
        {
            Console.WriteLine("The dog's door opens.");
            open = true;

            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(Run);
            timer.Interval = 5000;
            timer.Enabled = true;
        }

        private void Run(object sender, ElapsedEventArgs e)
        {
            Close();
            timer.Enabled = false;
        }

        public void Close()
        {
            Console.WriteLine("The dog's door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }

        public void AddAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> AllowedBarks { get { return allowedBarks; } }
    }
}
