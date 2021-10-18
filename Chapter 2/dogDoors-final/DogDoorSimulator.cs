using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_2.dogDoors_final
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
            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("Fido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control.");
            remote.PressButton();

            Console.WriteLine("Fido's back inside...");
            Console.ReadKey();

        }
    }
}
