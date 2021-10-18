using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3.dogDoors_final
{
    public class Remote
    {
        private DogDoor door;

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
            }
        }

    }
}
