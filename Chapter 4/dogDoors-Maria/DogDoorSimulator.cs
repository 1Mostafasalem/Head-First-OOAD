using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Maria
{
    public class DogDoorSimulator
    {
        public static void main(String[] args)
        {
            DogDoor door = new DogDoor();
            door.setAllowedBark(new Bark("rowlf"));
            door.setAllowedBark(new Bark("rooowlf"));
            door.setAllowedBark(new Bark("rawlf"));
            door.setAllowedBark(new Bark("woof"));
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);


            Console.WriteLine("\nBruce starts barking.");
            recognizer.recognize(new Bark("rowlf"));


            Console.WriteLine("\nBruce has gone outside...");


            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception ex) { }

            Console.WriteLine("\nBruce's all done...");
            Console.WriteLine("...but he's stuck outside!");

            // Simulate the hardware hearing a bark (not Bruce!)
            Console.WriteLine("A small dog starts barking.");
            recognizer.recognize(new Bark("yip")); 
            try
            {
                Thread.Sleep(5000);
            }
            catch (Exception ex) { }

            Console.WriteLine("Fido starts barking...");
            recognizer.recognize(new Bark("rowlf"));
            Console.WriteLine("Fido's back inside...");
            Console.ReadKey();

        }
    }
}
