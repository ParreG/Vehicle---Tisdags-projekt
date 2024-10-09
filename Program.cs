using System.Reflection;

namespace Vehicle___Tisdags_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Vehicle.AddVehicle(vehicles, new Car("Mercedes", "GLC", 5, "ROD 398"));
            Vehicle.AddVehicle(vehicles, new Car("Mercedes", "GLA", 5, "ABC 123"));
            Vehicle.AddVehicle(vehicles, new Car("BMW", "X3", 5, "DEF 456"));
            Vehicle.AddVehicle(vehicles, new Car("Audi", "A6", 5, "GHI 789"));
            Vehicle.AddVehicle(vehicles, new Car("Tesla", "Model S", 5, "JKL 101"));
            Vehicle.AddVehicle(vehicles, new Car("Volvo", "XC60", 5, "MNO 202"));

            Vehicle.AddVehicle(vehicles, new Motorcycle("Honda", "Cbr", 0, "PQR 303"));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Honda", "CB500F", 0, "STU 404"));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Suzuki", "GSX-R600", 0, "VWX 505"));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Yamaha", "YZF-R1", 0, "YZA 606"));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Ducati", "Panigale V2", 0, "BCD 707"));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Kawasaki", "Z900", 0, "EFG 808"));

            Vehicle.AddVehicle(vehicles, new Truck("Volvo", "XCH83", 2, "HIJ 909"));
            Vehicle.AddVehicle(vehicles, new Truck("Volvo", "FH16", 2, "KLM 101"));
            Vehicle.AddVehicle(vehicles, new Truck("Scania", "R450", 2, "NOP 202"));
            Vehicle.AddVehicle(vehicles, new Truck("MAN", "TGX", 3, "QRS 303"));
            Vehicle.AddVehicle(vehicles, new Truck("Mercedes-Benz", "Actros", 2, "TUV 404"));
            Vehicle.AddVehicle(vehicles, new Truck("DAF", "XF", 3, "WXY 505"));



            for (int i = 0; i < vehicles.Count; i++)
            {
            
                foreach (var Vehicle in vehicles)
                {
                    
                    Console.WriteLine($"Bil nr {i+1}\nMärke: {Vehicle.Brand} \nModell: {Vehicle.Model} \nAntal dörrar: {Vehicle.Door} \nReg nr: {Vehicle.Registrationnumber}\n");

                    i++;
                }
            }


            Console.WriteLine("Skriv ett reg nr du vill ta bort: ");
            string removeReg = Console.ReadLine();

            Vehicle vehicleToRemove = vehicles.Find(x => x.Registrationnumber == removeReg);
            if (vehicleToRemove != null)
            {
                Vehicle.RemoveVehicle(vehicles, vehicleToRemove);
            }


            List<Motorcycle> allMotorcycle = Vehicle.FilterVehicles<Motorcycle>(vehicles);
            
            foreach (var Motorcycle in allMotorcycle)
            {
                
                Console.WriteLine($"Motorcycel modellen är: {Motorcycle.Brand} \nReg nr: {Motorcycle.Registrationnumber}\n ");
            }





        }
    }
}
