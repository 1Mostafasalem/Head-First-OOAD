using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Chapter_2.dogDoors_final
{
    public class Remote
    {
        private DogDoor door;
        Timer checkForTime = new Timer();

        public Remote(DogDoor _door)
        {
            door = _door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
                checkForTime.Interval = 5000;
                checkForTime.Elapsed += run;
                checkForTime.AutoReset = false;
                checkForTime.Start();
            }
        }

        public void run(object sender, ElapsedEventArgs e)
        {
                checkForTime.Stop();
                door.Close();
        }
    }
}

