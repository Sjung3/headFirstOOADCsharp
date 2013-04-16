using System;
using System.Collections.Generic;

namespace GameDesigner
{
    public class Unit
    {
        private string type;
        private List<Object> properties;

        public Unit()
        {
            properties = new List<Object>();
        }

        public string Type { get; set; }
        public List<Object> Properties { get; set; }
    }
}