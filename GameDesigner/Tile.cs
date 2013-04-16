using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDesigner
{
    public class Tile
    {
        private List<Unit> units;

        public Tile()
        {
            units = new List<Unit>();
        }
        public void AddUnit(Unit unit)
        {
            units.Add(unit);
        }

        public void RemoveUnit(Unit unit)
        {
            units.Remove(unit);
        }

        public void RemoveUnits()
        {}

        public List<Unit> Units { get { return units; } }

    }
}
