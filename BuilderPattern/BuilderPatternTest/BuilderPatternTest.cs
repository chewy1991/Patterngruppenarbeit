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
            //act
            director.Construct();
            var MyCar = builder.GetResult();
            //Assert
            Assert.IsTrue((MyCar.Make.Equals("Ferrari") && MyCar.Model.Equals("488 Spider") && MyCar.Colour.Equals("Red") && MyCar.NumDoors == 2));

        }

    }
}
