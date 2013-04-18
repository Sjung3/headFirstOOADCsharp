using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDesigner
{
    public class UnitGroup
    {
        private Dictionary<int, object> units;
 
        public UnitGroup(List<Unit> unitList)
        {
            units = new Dictionary<int, object>();

            foreach (var unit in unitList)
            {
                units.Add(unit.Id, unit);
            }
        }

        public UnitGroup() : this(new List<Unit>())
        {
        }

        public void AddUnit(Unit unit)
        {
            units.Add(unit.Id, unit);
        }

        public void RemoveUnit(int id)
        {
            units.Remove(id);
        }

        public void RemoveUnit(Unit unit)
        {
            units.Remove(unit.Id);
        }

        public Unit GetUnit(int id)
        {
            return (Unit)units[id];
        }

        public List<Unit> GetUnits()
        {
            List<Unit> unitList = new List<Unit>();
            foreach (Unit unit in units.Values)
            {
                unitList.Add(unit);
            }
            return unitList;
        }
    }
}
