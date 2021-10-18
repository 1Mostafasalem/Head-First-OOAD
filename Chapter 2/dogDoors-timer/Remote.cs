using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace Chapter_2.dogDoors_timer
{
    public class Remote
    {
        private DogDoor door;
        Timer checkForTime = new Timer(5000);
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
                
                checkForTime.Elapsed += run;
                checkForTime.Start();

            }
        }
       public void run(object sender, ElapsedEventArgs e)
        {
            door.Close();
            checkForTime.Stop();
        }


    }
}
