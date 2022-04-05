using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany //DONE

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle //DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company //DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes //DONE

            /*Create 2 members that are specific to each class 
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. //DONE used a comma
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car();
            var truck = new Truck();
            var SUV = new SUV();

            car.HasConvertibleTop = true;
            car.HasTrunk = true;
            car.HowManyDoors = 2;
            car.HasEngine = true;
            car.HasWheels = true;
            car.Make = "Mazda";
            car.Motto = "Mazda Feel Alive";
            car.Logo = "A silver circle with an M in the middle";

            truck.TruckBedSize = 5.5;
            truck.HasFourWheelDrive = true;
            truck.HowManyDoors = 4;
            truck.HasEngine = true;
            truck.HasWheels = true;
            truck.Make = "Ford";
            truck.Motto = "Built Ford Tough";
            truck.Logo = "Oblong blue circle with the word FORD inside";

            SUV.HasCargoHold = "yes";
            SUV.HowManyDoors = 4;
            SUV.HasEngine = true;
            SUV.HasWheels = true;
            SUV.ThirdRowSeat = true;
            SUV.Make = "mitsubishi";
            SUV.Motto = "Built Ford Tough";
            SUV.Logo = "Oblong blue circle with the word FORD inside";

            Console.WriteLine($"I have three vehicles here one is a car, one is a truck, and one is a SUV,");
            Console.WriteLine($" Which would you like to choose?");



        }



    }
    }

        
}

