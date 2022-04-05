using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car:IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public bool HasConvertibleTop { get; set; }
        public bool HasWheels { get; set; }
        public int HowManyDoors { get; set; }
        public bool HasEngine { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }
    }
}
