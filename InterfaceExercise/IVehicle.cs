using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        //Create 4 members that Car, Truck, & SUV all have in common.


        public bool HasWheels { get; set; }
        public int HowManyDoors { get; set; } 
        public bool HasEngine { get; set; }
        public string Make { get; set; } 


    }   
}
