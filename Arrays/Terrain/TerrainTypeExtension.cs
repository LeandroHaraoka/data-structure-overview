using System;

namespace DataStructureOverview.Arrays.Terrain
{
    public static class TerrainTypeExtension
    {
        public static ConsoleColor GetColor(this TerrainType terrainType)
        {
            switch (terrainType)
            {
                case TerrainType.Grass : return ConsoleColor.Green;
                case TerrainType.Sand : return ConsoleColor.Yellow;
                case TerrainType.Water : return ConsoleColor.Blue;
                default : return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar(this TerrainType terrain)
        {
            switch (terrain)
            {
                case TerrainType.Grass : return '\u201c';
                case TerrainType.Sand : return '\u25cb';
                case TerrainType.Water : return '\u2248';
                default : return '\u25cf';
            }
        }
    }
}