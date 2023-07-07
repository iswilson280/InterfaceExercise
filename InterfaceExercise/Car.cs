using System;
namespace InterfaceExercise
{
	public class Car : IVehicle , ICompany
	{
        public string EngineSize { get; set; }

        public string HonkNoise { get; set; }
        public string Name { get  ; set  ; }
        public string Logo { get  ; set  ; }
        public int NumberOfWheels { get  ; set  ; }
        public bool HasTailight { get  ; set  ; }
        public string Fuelgrade { get  ; set  ; }
        public bool HasHeadLights { get ; set  ; }
    }
}

