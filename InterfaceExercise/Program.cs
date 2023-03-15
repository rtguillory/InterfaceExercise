using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany
            //Done
            //Create 3 classes called Car , Truck , & SUV
            //Done
            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //Done

            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Done

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Done


            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            SUV sUV1 = new SUV { HasThirdRow = false, CargoHoldCuFeet = 95, Year = 2022, VIN = "5J8YE1H45NL005283", Make = "Acura", Model = "MDX", Motto = "Precision Crafted Performance", YearEstablished = 1986 };
            Car car1 = new Car { IsCompact = true, TrunkCuFeet = 13, Year = 2023, VIN = "1NXBU40E49Z015652", Model = "Corolla", Make = "Toyota", Motto = "Let's Go Places", YearEstablished = 1937  };
            Truck truck1 = new Truck { BedLength = 6.5, ExtendedCab = true, Year = 2017, VIN = "1GCGTDEN5H1257789", Model = "Colorado Z71", Make = "Chevrolet", Motto = "Find New Roads", YearEstablished = 1911 };

            Console.WriteLine(car1);
            //car1.PrintInfo();
            Console.WriteLine(truck1.PrintInfo());
            //truck1.PrintInfo();
            Console.WriteLine();
            sUV1.PrintInfo();
        }
    }
}
