using System.Reflection;

namespace Vehicle___Tisdags_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();


            Vehicle.AddVehicle(vehicles, new Car("Mercedes", "GLC", 5));
            Vehicle.AddVehicle(vehicles, new Car("Mercedes", "GLA", 5));
            Vehicle.AddVehicle(vehicles, new Car("BMW", "X3", 5));
            Vehicle.AddVehicle(vehicles, new Car("Audi", "A6", 5));
            Vehicle.AddVehicle(vehicles, new Car("Tesla", "Model S", 5));
            Vehicle.AddVehicle(vehicles, new Car("Volvo", "XC60", 5));

            Vehicle.AddVehicle(vehicles, new Motorcycle("Honda", "Cbr", 0));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Honda", "CB500F", 0));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Suzuki", "GSX-R600", 0));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Yamaha", "YZF-R1", 0));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Ducati", "Panigale V2", 0));
            Vehicle.AddVehicle(vehicles, new Motorcycle("Kawasaki", "Z900", 0));

            Vehicle.AddVehicle(vehicles, new Truck("Volvo", "XCH83", 2));
            Vehicle.AddVehicle(vehicles, new Truck("Volvo", "FH16", 2));
            Vehicle.AddVehicle(vehicles, new Truck("Scania", "R450", 2));
            Vehicle.AddVehicle(vehicles, new Truck("MAN", "TGX", 3));
            Vehicle.AddVehicle(vehicles, new Truck("Mercedes-Benz", "Actros", 2));
            Vehicle.AddVehicle(vehicles, new Truck("DAF", "XF", 3));


            for (int i = 0; i < vehicles.Count; i++)
            {


                foreach (var Vehicle in vehicles)
                {
                    
                    Console.WriteLine($"Bil nr {i+1}\nMärke: {Vehicle.Brand} \nModell: {Vehicle.Model} \nAntal dörrar: {Vehicle.Door}\n");
                    i++;
                }
            }

            Console.WriteLine("Nu kan du få radera någon av fordonen! Skriv nummer på vilket fordon du vill radera: ");
            int remove = Convert.ToInt32(Console.ReadLine());
            Vehicle.RemoveVehicle(vehicles, remove);

            var motorcyclar = Vehicle.FilterVehicles<Motorcycle>(vehicles);
            
            

        }
    }
}
