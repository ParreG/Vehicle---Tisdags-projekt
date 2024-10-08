using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle___Tisdags_projekt
{
    internal class Truck : Vehicle, IDriveable
    {
        public Truck(string brand, string model, int door) : base(brand, model, door)
        {
            
        }
        public void Drive()
        {
            Console.WriteLine($"{Brand} kör hur bra som helst!");
        }


    }
}
