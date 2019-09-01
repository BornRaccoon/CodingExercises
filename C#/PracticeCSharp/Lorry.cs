using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public class Lorry : Vehicle
    {
        public bool fullOfCargo = false;

        public Lorry(string name, int numberOfWheels, vehicleColor color) : base(name, numberOfWheels, color) 
        {
        }

        public bool isFullOfCargo()
        {
            return fullOfCargo;
        }

        public void PrintLorryColor()
        {
            Console.WriteLine("The color is: " + base.color.ToString());
        }


        public override void RemoveVehicle()
        {
            Console.WriteLine("Vehicle cannot be removed");
        }

        public override void Move()
        {
            Console.WriteLine("Moving lorry");
        }
    }
}
