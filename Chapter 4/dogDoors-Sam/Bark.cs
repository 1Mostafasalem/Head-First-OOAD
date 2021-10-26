using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4.dogDoors_Sam
{
    public class Bark
    {
        private string sound;

        public Bark(string sound)
        {
            this.sound = sound;
        }

        public string getSound()
        {
            return sound;
        }

        public bool equals(Bark bark)
        {
                Bark otherBark = bark;
                if (this.sound.Equals(otherBark.sound))
                {
                    return true;
                }

            return false;
        }

    }
}
