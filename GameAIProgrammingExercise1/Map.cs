using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAIProgrammingExercise1
{
    public static class Map
    {

        public static bool[,] WorldMap = new bool[12, 12];

        public static void SetUp()
        {
            for(int i = 0; i < WorldMap.GetLength(0); i++)
            {
                for(int j = 0; j < WorldMap.GetLength(1); j++)
                {
                    WorldMap[i, j] = true;
                }
                
            }
        }
        public static void BuildWall()
        {
            for (int j = 0; j < WorldMap.GetLength(1); j++)
            {
                WorldMap[0, j] = false;
                WorldMap[11, j] = false;
            }
            for (int i = 0; i < WorldMap.GetLength(0); i++)
            {
                WorldMap[i, 0] = false;
                WorldMap[i, 11] = false;
            }
        }
        
        public static void Obstacles()
        {
            WorldMap[2, 3] = false;

            WorldMap[3, 6] = false;
            WorldMap[3, 7] = false;
            WorldMap[3, 8] = false;

            WorldMap[4, 2] = false;
            WorldMap[4, 3] = false;
            WorldMap[4, 4] = false;

            WorldMap[5, 8] = false;
            WorldMap[5, 9] = false;
            WorldMap[5, 10] = false;

            WorldMap[6, 1] = false;
            WorldMap[6, 2] = false;
            WorldMap[6, 3] = false;

            WorldMap[7, 6] = false;
            WorldMap[7, 7] = false;

            WorldMap[9, 2] = false;
            WorldMap[9, 3] = false;
            WorldMap[9, 4] = false;
            WorldMap[9, 5] = false;
            WorldMap[9, 8] = false;
            WorldMap[9, 9] = false;
            WorldMap[9, 10] = false;

        }

    }


}
