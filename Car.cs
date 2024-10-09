using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle___Tisdags_projekt
{
    public class Car : Vehicle,IDriveable
    {
        public Car(string brand, string model, int door, string registrationnumber) : base(brand, model, door, registrationnumber)
        {
            
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} kör hur bra som helst!");
        }


    }
}
