using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
        public string BedSize { get; set; }

        public bool IsCrewMax { get; set; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }
        public int NumberOfWheels { get; set; }
        public bool HasTailight { get; set; }
        public string Fuelgrade { get; set; }
        public bool HasHeadLights { get; set; }
    }
}

