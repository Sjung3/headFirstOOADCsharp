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
            if (properties.ContainsKey(property))
                properties.Remove(property);
            properties.Add(property, value);
        }

        public Object GetProperty(string property)
        {
            if (properties == null)
                throw new SystemException("What are you doing? No properties!");

            Object value = properties[property];
            if (value == null)
                throw new SystemException("You're screwing up! No property value!");
            else
                return value;
        }

        public void AddWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
        }
    }
}