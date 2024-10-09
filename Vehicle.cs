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
        public string Registrationnumber { get; set; }

        public Vehicle(string brand, string model, int door, string registrationnumber)
        {
            Brand = brand;
            Model = model;
            Door = door;
            Registrationnumber = registrationnumber;
        }

        public static void AddVehicle(List<Vehicle> vehicle, Vehicle vehicle1)
        {
            vehicle.Add(vehicle1);
        }

        public static List<T> FilterVehicles<T>(List<Vehicle> vehicles) where T : Vehicle
        {
            return vehicles.OfType<T>().ToList();
        }

        public static void RemoveVehicle(List<Vehicle> vehicles, Vehicle vehicle)
        {
                vehicles.Remove(vehicle);
                Console.WriteLine($"Nu har du raderat: \nMärke: {vehicle.Brand} \nModell: {vehicle.Model} \nAntal dörrar: {vehicle.Door} \nReg nr: {vehicle.Registrationnumber}\n");
            
        }


    }
}
