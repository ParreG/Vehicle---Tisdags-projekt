using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle___Tisdags_projekt
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Door { get; set; }

        public Vehicle(string brand, string model, int door)
        {
            Brand = brand;
            Model = model;
            Door = door;
        }

        public static void AddVehicle(List<Vehicle> vehicle, Vehicle vehicle1)
        {
            vehicle.Add(vehicle1);
        }

        public static List<T> FilterVehicles<T>(List<Vehicle> vehicles) where T : Vehicle
        {
            return vehicles.OfType<T>().ToList();
        }

        public static void RemoveVehicle(List<Vehicle> vehicles, int index)
        {
            Console.WriteLine($"\nSäljer fordon: {vehicles[index-1]}");
            vehicles.RemoveAt(index-1);

        }


    }
}
