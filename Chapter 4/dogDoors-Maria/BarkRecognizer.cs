using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Maria
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
            List<Bark> allowedBarks = door.getAllowedBark();
            for (int i = 0; i < allowedBarks.Count; i++)
            {
                if (allowedBarks[i].equals(bark))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed.");
        }

    }
}
