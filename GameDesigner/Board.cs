using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameDesigner
{
    public class Board
    {
        private int height, width;
        private ArrayList tiles;

        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
            Initialize();
        }

        private void Initialize()
        {
            tiles = new ArrayList(width);
            for (int i = 0; i < width; i++)
            {
                tiles.Add(new ArrayList(height));
                for (int j = 0; j < height; j++)
                {
                    ((ArrayList)tiles[i]).Add(new Tile());
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return (Tile)((ArrayList)tiles[x - 1])[y - 1];
        }

        public void AddUnit(Unit unit, int x, int y)
        {
            Tile tile = GetTile(x, y);
            tile.AddUnit(unit);
        }

        public void RemoveUnit(Unit unit, int x, int y)
        {
            Tile tile = GetTile(x, y);
            tile.RemoveUnit(unit);
        }

        public void RemoveUnits(int x, int y)
        {
            Tile tile = GetTile(x, y);
            tile.RemoveUnits();
        }

        public List<Unit> GetUnits(int x, int y)
        {
            return GetTile(x, y).Units;
        }
    }
}
