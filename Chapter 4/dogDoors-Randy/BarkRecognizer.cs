using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Randy
{
    public class BarkRecognizer
    {
        private DogDoor door;
        public BarkRecognizer(DogDoor _door)
        {
            door = _door;
        }
        public void recognize(String bark)
        {
            Console.WriteLine("   BarkRecognizer: Heard a '" + bark + "'");
            if (door.getAllowedBark().Equals(bark))
            {
                door.Open();
            }
            else
            {
                Console.WriteLine("This Dog is not allowed");
            }
        }

    }
}
