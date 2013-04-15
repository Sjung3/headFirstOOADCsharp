using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarApp
{
    public class InstrumentSpec
    {
        private Dictionary<string, string> properties;

        public InstrumentSpec(Dictionary<string, string> properties)
        {
            if (properties == null)
                this.properties = new Dictionary<string, string>();
            else
                this.properties = new Dictionary<string, string>(properties);
        }

        public string this[string propertyName]
        {
            get { return properties[propertyName].ToString(); }
        }

        public Dictionary<string, string> Properties { get { return properties; } }
        
        public bool Matches(InstrumentSpec otherSpec)
        {
            foreach (var propertyName in otherSpec.Properties.Keys)
            {
                if (properties[propertyName] != otherSpec[propertyName])
                    return false;
            }
            return true;
        }
    }
}
