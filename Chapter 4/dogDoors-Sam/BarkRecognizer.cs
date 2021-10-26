using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Sam
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(Bark bark)
        {
            Console.WriteLine("   BarkRecognizer: Heard a '" + bark.getSound() + "'");
            if (door.getAllowedBark().equals(bark))
            {
                door.Open();
            }
            else
            {
                Console.WriteLine("This dog is not allowed.");
            }
        }

    }
}
