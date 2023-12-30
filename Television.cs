using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The  TV is Off");
            
        }

        public void On()
        {
            Console.WriteLine("The  TV is On");

        }

        public void VolumeUp()
        {
            if (Volume < 100)
            {
                Volume++;
                Console.WriteLine("The TV Volumne is {0}", Volume);
            }
        }

        public void VolumeDown()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.WriteLine("The TV Volumne is {0}", Volume);
            }
        }
    }
    
}
