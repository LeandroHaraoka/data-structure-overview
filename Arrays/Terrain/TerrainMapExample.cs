using System;
using System.Text;

namespace DataStructureOverview.Arrays.Terrain
{
    public class TerrainMapExample
    {
        public void Run()
        { 
		    var map = CreateMap();
            ShowMap(map);
        }
	
		private TerrainType[,] CreateMap()
		{
			var snd = TerrainType.Sand;
            var grs = TerrainType.Grass;
            var wll = TerrainType.Wall;
            var wtr = TerrainType.Water;

			TerrainType[,] map =
		    {
		        {snd, snd, snd, snd, grs, grs, grs, grs, grs, grs},
		        {snd, snd, snd, snd, grs, grs, grs, grs, grs, grs},
		        {snd, snd, snd, snd, grs, grs, grs, grs, grs, grs},
		        {snd, snd, snd, snd, grs, grs, grs, grs, grs, grs},
		        {snd, snd, snd, snd, snd, snd, snd, wll, wll, wll},
		        {snd, snd, snd, snd, snd, snd, snd, wll, snd, snd},
		        {snd, snd, snd, snd, snd, snd, snd, wll, snd, snd},
		        {wtr, wtr, wtr, wtr, wtr, wtr, wtr, wll, snd, snd},
		        {wtr, wtr, wtr, wtr, wtr, wtr, wtr, wll, snd, snd},
		        {wtr, wtr, wtr, wtr, wtr, wtr, wtr, wll, wtr, wtr},
		        {wtr, wtr, wtr, wtr, wtr, wtr, wtr, wll, wtr, wtr}
			};

			return map;
		}

        private void ShowMap(TerrainType[,] map)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

		    for (int row = 0; row < map.GetLength(0); row++)
		    {
		        for (int column = 0; column < map.GetLength(1); column++)
		        {
		            Console.ForegroundColor = map[row, column].GetColor();
		            Console.Write(map[row,column].GetChar() + "");
		        }
		        Console.WriteLine("");
		    }
		    Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}