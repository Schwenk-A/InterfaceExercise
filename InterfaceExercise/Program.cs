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
            var suv = new SUV();


            suv.HasCargoHold = "yes";
            suv.HowManyDoors = 4;
            suv.HasEngine = true;
            suv.HasWheels = true;
            suv.ThirdRowSeat = true;
            suv.Make = "mitsubishi";
            suv.Motto = "Drive your Ambition";
            suv.Logo = "Red diamond with two red parallelogram underneath";


            truck.TruckBedSize = 5.5;
            truck.HasFourWheelDrive = true;
            truck.HowManyDoors = 4;//--
            truck.HasEngine = true;//--
            truck.HasWheels = true;
            truck.Make = "Ford";
            truck.Motto = "Built Ford Tough";
            truck.Logo = "Oblong blue circle with the word FORD inside";

            car.HasConvertibleTop = true;
            car.HasTrunk = true;
            car.HowManyDoors = 2;
            car.HasEngine = true;
            car.HasWheels = true;
            car.Make = "Mazda";
            car.Motto = "Mazda Feel Alive";
            car.Logo = "A silver circle with an M in the middle";

            Console.WriteLine($"I have three vehicles here one is a car, one is a truck, and one is a SUV,");
            Console.WriteLine($" Here is what we have");
            Console.ReadLine();

            //_____________________________________________________________________


            Console.Clear();
            Console.WriteLine($"{car.Make} The company motto is{car.Motto}");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Lets do a checklist to see if it ready to drive");
            Console.WriteLine($"Engine?             {car.HasEngine}");
            Console.WriteLine($"Wheels?             {car.HasWheels}");
            Console.WriteLine($"How many Doors?     {car.HowManyDoors}");
            Console.WriteLine($"FConvertible Top?   {car.HasConvertibleTop}");
            Console.WriteLine($"Trunk size?         {car.HasTrunk}");
            Console.WriteLine($"and last but not least the logo on the side {car.Logo}");
            Console.WriteLine("All set! Next vehicle");
            Console.ReadLine();
















            //SUV VEHICLE________________________________________________________________
            Console.Clear();
            Console.WriteLine($"{truck.Make} The company motto is{truck.Motto}");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Lets do a checklist to see if it ready to drive");
            Console.WriteLine($"Engine?             {truck.HasEngine}");
            Console.WriteLine($"Wheels?             {truck.HasWheels}");
            Console.WriteLine($"How many Doors?     {truck.HowManyDoors}");
            Console.WriteLine($"Four Wheel Drive?   {truck.HasFourWheelDrive}");
            Console.WriteLine($"TruckBedSize?       {truck.TruckBedSize}");
            Console.WriteLine($"and last but not least the logo on the side {truck.Logo}");
            Console.WriteLine("All set! Next vehicle");
            Console.ReadLine();


            //SUV VEHICLE________________________________________________________________

            Console.Clear();
            Console.WriteLine($"{suv.Make} The company motto is{suv.Motto}");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Lets do a checklist to see if it ready to drive");
            Console.WriteLine($"Engine?             {suv.HasEngine}");
            Console.WriteLine($"Wheels?             {suv.HasWheels}");
            Console.WriteLine($"How many Doors?     {suv.HowManyDoors}");
            Console.WriteLine($"Third row seat?     {suv.ThirdRowSeat}");
            Console.WriteLine($"Cargo hold?         {suv.HasCargoHold}");
            Console.WriteLine($"and last but not least the logo on the side {suv.Logo}");
            Console.WriteLine("All set! All vehicles ready!");
            Console.ReadLine();









        }


    
    }      
}

