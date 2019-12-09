using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;
using BuilderPattern.Classes;
using BuilderPattern.Director;

namespace BuilderPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = new FerrariBuilder();
            var director = new SportscarBuilderDirector(builder);
            director.Construct();

            Car MyCar = builder.GetResult();

            Console.WriteLine($"Marke: {MyCar.Make}, Model: {MyCar.Model}, Farbe: {MyCar.Colour}, Türen: {MyCar.NumDoors}");
            Console.ReadLine();
        }
    }
}
