using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public int NumberOfWheels { get; set; }
        public bool HasTailight { get; set; }
        public string Fuelgrade { get; set; }
        public bool HasHeadLights { get; set; }
    }
}

