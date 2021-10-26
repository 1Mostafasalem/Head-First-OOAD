using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Sam
{
    public class DogDoorSimulator
    {
        public static void main(String[] args)
        {
            DogDoor door = new DogDoor();
            door.setAllowedBark(new Bark("Rowlf"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            recognizer.recognize(new Bark("Rowlf"));

            Console.WriteLine("\nFido has gone outside...");
            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }

            Console.WriteLine("\nFido's all done...");
            Console.WriteLine("...but he's stuck outside!");

            // Simulate the hardware hearing a bark (not Bruce!)
            Console.WriteLine("A small dog starts barking.");
            recognizer.recognize(new Bark("Yip"));
            try
            {
                Thread.Sleep(5000);
            }
            catch (Exception ex) { }

            Console.WriteLine("Fido starts barking...");
            recognizer.recognize(new Bark("Rowxlf"));

            Console.WriteLine("Fido's back inside...");
            Console.ReadKey();

        }
    }
}
