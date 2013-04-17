using System;
using System.Collections.Generic;

namespace GameDesigner
{
    public class Unit
    {
        private int id;
        private Dictionary<string, Object> properties;
        private List<Weapon> weapons;

        public Unit(int id)
        {
            this.id = id;
            properties = new Dictionary<string, Object>();
            weapons = new List<Weapon>();
        }

        public string Type { get; set; }

        public int Id { get { return id; } }

        public string Name { get; set; }

        public List<Weapon> Weapons { get { return weapons; } }

        public void SetProperty(string property, Object value)
        {
            properties.Add(property, value);
        }

        public Object GetProperty(string property)
        {
            return properties[property];
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }
    }
}