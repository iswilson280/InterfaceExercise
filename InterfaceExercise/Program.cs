using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - done



            //Create 3 classes called Car , Truck , & SUV- done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.- done
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company- done
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class - done
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values


            Car mycar = new Car();

            mycar.Name = "Jaguar";
            mycar.Logo = "Jaguar cat";
            mycar.EngineSize = "V8";
            mycar.HonkNoise = "loud";
            mycar.NumberOfWheels = 4;
            mycar.HasTailight = true;
            mycar.HasHeadLights = true;
            mycar.Fuelgrade = "gasoline";
               
            Truck mytruck = new Truck();

            mytruck.Name = "Chevrolet";
            mytruck.Logo = "chevy bowtie";
            mytruck.IsCrewMax = true;
            mytruck.BedSize = "standard";
            mytruck.NumberOfWheels = 4;
            mytruck.HasTailight = true;
            mytruck.HasHeadLights = true;
            mytruck.Fuelgrade = "gasoline";

            SUV mysuv = new SUV();

            mysuv.Name = "Jaguar";
            mysuv.Logo = "Jaguar cat";
            mysuv.CargoSize = "large";
            mysuv.IsDriveable = true;
            mysuv.NumberOfWheels = 4;
            mysuv.HasTailight = true;
            mysuv.HasHeadLights = true;
            mysuv.Fuelgrade = "gasoline";

            List<IVehicle> vehiclelist = new List<IVehicle>();
            vehiclelist.Add(mycar);
            vehiclelist.Add(mytruck);
            vehiclelist.Add(mysuv);

            foreach (IVehicle item in vehiclelist)
            {
                Console.WriteLine($"Fuel Grade: {item.Fuelgrade}");
                Console.WriteLine($"Has Tail Lights: {item.HasTailight}");
                Console.WriteLine($"Has Head Lights: {item.HasHeadLights}");
                Console.WriteLine($"Number Of Wheels: {item.NumberOfWheels}");


                Console.WriteLine();
            }



        }

    }

}





