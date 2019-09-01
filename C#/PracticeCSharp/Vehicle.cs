using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    public abstract class Vehicle
    {
        public enum vehicleColor
        {
            BROWN,
            GREEN,
            BLACK
        }

        protected string name;
        protected int numberOfWheels;
        protected vehicleColor color;

        public Vehicle(string name, int numberOfWheels, vehicleColor color)
        {
            this.name = name;
            this.numberOfWheels = numberOfWheels;
            this.color = color;
        }

        public void Print(string comment)
        {
            Console.WriteLine("Car {0} has this many wheels {1}", name, numberOfWheels);
            Console.WriteLine("People think this {0} about the car.", comment);
        }

        public void Print()
        {
            Console.WriteLine("Car {0} has this many wheels {1}", name, numberOfWheels);
        }

        public virtual void RemoveVehicle()
        {
            Console.WriteLine("Vehicle was removed");
        }

        public abstract void Move();
       
    }
}
