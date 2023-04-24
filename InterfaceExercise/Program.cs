using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SUV Jeep = new SUV();
            Jeep.Color = "Black";
            Jeep.Name = "Jeep";
            Jeep.NumberofWheels = 4;
            Jeep.Slogan = "Legends aren't born, they are made";
            Jeep.TransmissionType = "Automatic";
            Jeep.FourWheelDrive = true;
            Jeep.Year = 2010;
            Jeep.NumberOfPassengers = 5;

            Console.WriteLine($"{Jeep.Name} - {Jeep.Slogan}");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"Year:{Jeep.Year}  Color: {Jeep.Color}");
            Console.WriteLine($"Transmission: {Jeep.TransmissionType}  4WD: {Jeep.FourWheelDrive}");
            Console.WriteLine($"Passengers: {Jeep.NumberOfPassengers}  Wheels: {Jeep.NumberofWheels}");
            Console.WriteLine("_______________________________________");

            Car Hyundai = new Car();
            Hyundai.Color = "Silver";
            Hyundai.Name = "Hyundai";
            Hyundai.NumberOfDoors = 4;
            Hyundai.NumberofWheels = 4;
            Hyundai.Slogan = "New thinking, new possibilities";
            Hyundai.TransmissionType = "Automatic";
            Hyundai.TrunkType = "Standard";
            Hyundai.Year = 2004;

            Console.WriteLine($"{Hyundai.Name} - {Hyundai.Slogan}");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"Year:{Hyundai.Year}  Color: {Hyundai.Color}");
            Console.WriteLine($"Transmission: {Hyundai.TransmissionType}  Doors: {Hyundai.NumberOfDoors}");
            Console.WriteLine($"Trunk: {Hyundai.TrunkType}  Wheels: {Hyundai.NumberofWheels}");
            Console.WriteLine("_______________________________________");

            Truck Ford = new Truck();
            Ford.Year = 2022;
            Ford.TransmissionType = "Automatic";
            Ford.TowLoad = 3325;
            Ford.Slogan = "Adventurous spirit";
            Ford.NumberofWheels = 4;
            Ford.Name = "Ford";
            Ford.Color = "Black";
            Ford.BedSize = 96;

            Console.WriteLine($"{Ford.Name} - {Ford.Slogan}");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"Year:{Ford.Year}  Color: {Ford.Color}");
            Console.WriteLine($"Transmission: {Ford.TransmissionType}  Wheels: {Ford.NumberofWheels}");
            Console.WriteLine($"Bed Size: {Ford.BedSize}  Tow Load: {Ford.TowLoad}");
            Console.WriteLine("_______________________________________");



        }
    }
}
