using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
    {
        public string CargoSize { get; set; }

        public  bool IsDriveable { get; set; }
        public string Name { get ; set ; }
        public string Logo { get ; set ; }
        public int NumberOfWheels { get; set; }
        public bool HasTailight { get; set; }
        public string Fuelgrade { get; set; }
        public bool HasHeadLights { get; set; }
    }
}

