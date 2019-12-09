using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Interface;

namespace BuilderPattern.Director
{
    public class SportscarBuilderDirector
    {
        private ICarBuilder _builder;

        public SportscarBuilderDirector(ICarBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            _builder.Colour = "Red";
            _builder.NumbDoors = 2;
        }

    }
}
