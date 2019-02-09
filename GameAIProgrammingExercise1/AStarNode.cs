using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAIProgrammingExercise1
{
    public class AStarNode
    {

        public int ParentX, ParentY, ThisNodeX, ThisNodeY;

        public int GCost, HCost, FCost;

        public AStarNode(int CXCoor, int CYCoor)
        {


            ThisNodeX = CXCoor;
            ThisNodeY = CYCoor;
        }

        public AStarNode(int PXCoor, int PYCoor, int CXCoor, int CYCoor, int gCost, int hCost)
        {

            ParentX = PXCoor;
            ParentY = PYCoor;
            ThisNodeX = CXCoor;
            ThisNodeY = CYCoor;
            GCost = gCost;
            HCost = hCost;

            CalculateFCost();
        }
        

        void CalculateFCost()
        {
            FCost = GCost + HCost;
        }
    }
}
