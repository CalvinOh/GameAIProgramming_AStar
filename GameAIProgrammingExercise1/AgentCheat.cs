using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAIProgrammingExercise1
{
    public class AgentCheat
    {

        int currentPosX, currentPosY;
        int TargetX, TargetY;
        int DifferenceX, DifferenceY;
        int Space;

        public bool[,] Degree = new bool[3, 3];

        bool Degree0, Degree45, Degree90, Degree135, Degree180, Degree225, Degree270, Degree315;
        public AgentCheat(int StartX, int StartY, int FinalX, int FinalY)
        {
            currentPosX = StartX;
            currentPosY = StartY;

            TargetX = FinalX;
            TargetY = FinalY;

        }

        public void CheckSpace()
        {
            Degree0 = Map.WorldMap[currentPosX, currentPosY - 1];
            Degree45 = Map.WorldMap[currentPosX + 1, currentPosY - 1];
            Degree90 = Map.WorldMap[currentPosX + 1, currentPosY];
            Degree135 = Map.WorldMap[currentPosX + 1, currentPosY + 1];
            Degree180 = Map.WorldMap[currentPosX, currentPosY + 1];
            Degree225 = Map.WorldMap[currentPosX - 1, currentPosY + 1];
            Degree270 = Map.WorldMap[currentPosX - 1, currentPosY];
            Degree315 = Map.WorldMap[currentPosX - 1, currentPosY - 1];    
        }

        public void CheckMovement()
        {
            DifferenceX = TargetX - currentPosX;
            DifferenceY = TargetY - currentPosY;

        }

        public void Movement()
        {
            
        }
    }
}
