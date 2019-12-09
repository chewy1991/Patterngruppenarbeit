using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Classes;

namespace BuilderPattern.Interface
{
    public interface ICarBuilder
    {
        string Colour { get; set; }
        int NumbDoors { get; set; }

        Car GetResult();
    }
}
