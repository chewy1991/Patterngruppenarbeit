using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Classes;
using BuilderPattern.Interface;

namespace BuilderPattern.Builder
{
    public class CorvetteBuilder : ICarBuilder
    {
        public string Colour { get; set; }
        public int NumbDoors { get; set; }

        public Car GetResult()
        {
            return NumbDoors >= 2 ? new Car("Chevrolet", "Corvette ZR1", Colour, NumbDoors) : null;
        }
    }
}
