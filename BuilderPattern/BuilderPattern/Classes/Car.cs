using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public string Colour { get; set; }

        public Car(string make, string model, string colour, int numDoors)
        {
            Make = make;
            Model = model;
            Colour = colour;
            NumDoors = numDoors;
        }
    }
}
