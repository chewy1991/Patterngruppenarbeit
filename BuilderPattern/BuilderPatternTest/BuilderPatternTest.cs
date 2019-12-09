using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;
using BuilderPattern.Director;
using NUnit.Framework;

namespace BuilderPatternTest
{
    [TestFixture]
    public class BuilderPatternTest
    {
        [Test]
        public void Ferrari_RedTwoDoors_IsTrue()
        {
            //arrange
            var builder = new FerrariBuilder();
            var director = new SportscarBuilderDirector(builder);
            var colour = "Red";
            var numboors = 2;
            //act
            director.Construct(colour,numboors);
            var MyCar = builder.GetResult();
            //Assert
            Assert.IsTrue((MyCar.Make.Equals("Ferrari") && MyCar.Model.Equals("488 Spider") && MyCar.Colour.Equals(colour) && MyCar.NumDoors == numboors));

        }

        [Test]
        public void Corvette_RedTwoDoors_IsTrue()
        {
            //arrange
            var builder = new CorvetteBuilder();
            var director = new SportscarBuilderDirector(builder);
            var colour = "Black";
            var numboors = 2;
            //act
            director.Construct(colour, numboors);
            var MyCar = builder.GetResult();
            //Assert
            Assert.IsTrue((MyCar.Make.Equals("Chevrolet") && MyCar.Model.Equals("Corvette ZR1") && MyCar.Colour.Equals(colour) && MyCar.NumDoors == numboors));

        }

    }
}
