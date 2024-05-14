using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufactoryLibrary
{
 
    public class BMW : Car
    {
        public override void Accelerate()
        {
            velocity += 15;
        }

        public BMW()
        {
            CarType = CarTypes.BMW;
        }
    }

    public enum CarTypes
    {
        BMW,
        Toyota,
        Audi,
        Honda
    }
}
