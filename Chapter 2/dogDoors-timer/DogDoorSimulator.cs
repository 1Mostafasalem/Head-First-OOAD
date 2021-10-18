using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_2.dogDoors_timer
{
    public class DogDoorSimulator
    {
        public static void main(String[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFido's all done...");

            Console.WriteLine("\nFido's back inside...");
            Console.ReadKey();

        }

    }
}
