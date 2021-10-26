using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_start
{
    public class DogDoorSimulator
    {
        public static void main(String[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            recognizer.recognize("Woof");

            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFido's all done...");
            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("Fido starts barking...");
            recognizer.recognize("Woof");

            Console.WriteLine("Fido's back inside...");
            Console.ReadKey();

        }
    }
}
