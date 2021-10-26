using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chapter_4.dogDoors_Randy
{
    public class DogDoor
    {
        private bool open;
        private string allowedBark;
        Timer timer = new Timer(5000);

        public DogDoor()
        {
            open = false;
        }
        public void setAllowedBark(String bark)
        {
            this.allowedBark = bark;
        }

        public String getAllowedBark()
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
