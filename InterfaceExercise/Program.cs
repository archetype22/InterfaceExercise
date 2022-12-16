using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany  [*]

            //Create 3 classes called Car , Truck , & SUV  [*]

            //In your IVehicle  [*]

            /* Create 4 members that Car, Truck, & SUV all have in common.  [*]
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany  [*]

            /*Create 2 members that are specific to each every company   [*]
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes  [*]

            /*Create 2 members that are specific to each class  [*]
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.  [*]
             * 
             * 
             */

            //Now, create objects of your 3 classes and give their members values;  [*]
            //"Creatively" display and organize their values
            Car car1 = new Car()
            {HasFourWheels = true,
            HasTrunk = true,
            IsFuelEfficient = true,
            Year = 2022,
            Make = "Porsche",
            Model = "Carrera",
            Logo = "Stuttgart horse centering a black, red, and yellow crest"
            };

            Truck truck1= new Truck() 
            {HasFourWheels = true,
            HasBed = true,
            HasTailgate = true, 
            Year = 2022,
            Make = "Dodge",
            Model = "Ram",
            Logo = "Crested Bighorn Ram"
            };
                       
            SUV suv1= new SUV() 
            { HasFourWheels = true,
            HasCargoSpace = true,   
            HasRearHatch = true,
            Year = 2022,
            Make = "Mercedes",
            Model = "GLC",
            Logo = "Three-pointed star within a sphere"
            };
            

            var autoList = new List<IVehicle>();

            autoList.Add(car1);
            autoList.Add(truck1); 
            autoList.Add(suv1);

            foreach (var vehicle in autoList) //use string interpolation
            {
                Console.WriteLine("Featuring: ");
                Console.WriteLine($"{vehicle.Year}");
                Console.WriteLine($"{vehicle.Make}");
                Console.WriteLine($"{vehicle.Model}");
                Console.WriteLine($"{vehicle.Logo}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
