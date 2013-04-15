using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public class GuitarSpec : InstrumentSpec
    {
        private int numStrings;

        public GuitarSpec(Builder builder, string model, Type type, Wood backwood, Wood topwood, int numStrings)
            : base(builder, model, type, backwood, topwood)
        {
            this.numStrings = numStrings;
        }

        public int NumStrings { get { return numStrings; } }

        public override bool Matches(InstrumentSpec otherSpec)
        {
            var spec = otherSpec as GuitarSpec;
            if (numStrings != spec.NumStrings)
                return false;
            return base.Matches(otherSpec);
        }
    }
}
