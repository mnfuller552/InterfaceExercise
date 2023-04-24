using System;
namespace InterfaceExercise
{
	public class Car : ICompany
	{
        public int NumberOfDoors { get; set; }
        public string TrunkType { get; set; }

        public string Slogan { get; set; }
        public string Name { get; set; }
        public string TransmissionType { get; set; }
        public string Color { get; set; }
        public int NumberofWheels { get; set; }
        public int Year { get; set; }


    }
}

