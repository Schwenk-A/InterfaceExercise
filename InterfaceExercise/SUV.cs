using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle ,ICompany
    {
        public string HasCargoHold { get; set; }
        public bool ThirdRowSeat { get; set; }
        public bool HasWheels {get ; set ; }
        public int HowManyDoors { get ; set ; }
        public bool HasEngine { get; set ; }
        public string Make { get ; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }
    }
}
