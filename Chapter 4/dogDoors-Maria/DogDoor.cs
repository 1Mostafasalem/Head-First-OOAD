using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chapter_4.dogDoors_Maria
{
    public class DogDoor
    {
        private bool open;
        private List<Bark> allowedBark;
        Timer timer = new Timer(5000);

        public DogDoor()
        {
            this.allowedBark = new List<Bark>();
            this.open = false;
        }

        public void setAllowedBark(Bark bark)
        {
            this.allowedBark.Add(bark);
        }

        public List<Bark> getAllowedBark()
        {
            return allowedBark;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;
            //checkForTime.Interval = 5000;
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            //checkForTime.AutoReset = false;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (open)
            {
                timer.Stop();
                Close();
            }
        }
    }
}
