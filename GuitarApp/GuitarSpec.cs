using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public class GuitarSpec
    {
        private Builder builder;
        private string model;
        private Type type;
        private Wood backwood;
        private Wood topwood;
        private int numStrings;

        public GuitarSpec(Builder builder, string model, Type type, Wood backwood, Wood topwood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backwood = backwood;
            this.topwood = topwood;
            this.numStrings = numStrings;
        }

        public Builder Builder { get { return builder; } }
        public string Model { get { return model; } }
        public Type Type { get { return type; } }
        public Wood BackWood { get { return backwood; } }
        public Wood TopWood { get { return topwood; } }
        public int NumStrings { get { return numStrings; } }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (builder != otherSpec.Builder)
                return false;
            if ((model != null) && (model != "") && (model.ToLower() != otherSpec.Model.ToLower()))
                return false;
            if (type != otherSpec.Type)
                return false;
            if (backwood != otherSpec.BackWood)
                return false;
            if (topwood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}
