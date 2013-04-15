using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public class MandolinSpec : InstrumentSpec
    {
        private Style style;

        public MandolinSpec(Builder builder, string model, Type type, Wood backwood, Wood topwood, Style style)
            : base(builder, model, type, backwood, topwood)
        {
            this.style = style;
        }

        public Style Style { get { return style; } }

        public override bool Matches(InstrumentSpec otherSpec)
        {
            var spec = otherSpec as MandolinSpec;
            if (style != spec.Style)
                return false;
            return base.Matches(otherSpec);
        }
    }
}
