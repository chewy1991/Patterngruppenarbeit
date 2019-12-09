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
            var corvBuilder = new CorvetteBuilder();
            var director = new SportscarBuilderDirector(builder);
            var director2 = new SportscarBuilderDirector(corvBuilder);
            director.Construct("Red", 2);
            director2.Construct("Black",2);
            Car MyCar = builder.GetResult();
            Car MyCorvette = corvBuilder.GetResult();

            Console.WriteLine($"Marke: {MyCar.Make}, Model: {MyCar.Model}, Farbe: {MyCar.Colour}, Türen: {MyCar.NumDoors}");
            Console.WriteLine($"Marke: {MyCorvette.Make}, Model: {MyCorvette.Model}, Farbe: {MyCorvette.Colour}, Türen: {MyCorvette.NumDoors}");
            Console.ReadLine();
        }
    }
}
