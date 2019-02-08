using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameAIProgrammingExercise1
{
    public class AStarAgent
    {

        List<AStarNode> OpenNodes;
        List<AStarNode> ClosedNodes;
        List<AStarNode> Neighbors;

        int StartingX, StartingY;
        int CurrentX, CurrentY;
        int TargetX, TargetY;

        public AStarAgent(int SX, int SY, int TX, int TY)
        {
            StartingX = SX;
            StartingY = SY;
            TargetX = TX;
            TargetY = TY;
            CurrentX = StartingX;
            CurrentY = StartingY;

            OpenNodes = new List<AStarNode>();
            ClosedNodes = new List<AStarNode>();
            Neighbors = new List<AStarNode>();
            ClosedNodes.Add(new AStarNode(StartingX,StartingY, StartingX, StartingY, CalculateG(StartingX, StartingY),CalculateH(StartingX, StartingY)));

        }

        public void SolvePuzzle()
        {
            Console.WriteLine((CurrentX - 1) + " , " + (CurrentY - 1));
            FindNeighbors();
            CheckNeighbours();
            int LowestFFound = 100000;
            AStarNode selectednode = new AStarNode(-1,-1);
            foreach (AStarNode m in OpenNodes)
            {
                if (LowestFFound > m.FCost)
                {
                    LowestFFound = m.FCost;
                }
                //need to be worked on, un finished, do not ignore;
            }
            foreach (AStarNode m in OpenNodes)
            {
                if (LowestFFound == m.FCost)
                {
                    selectednode = m;
                    
                }
            }
            OpenNodes.Remove(selectednode);
            ClosedNodes.Add(selectednode);
            CurrentX = selectednode.CurrentX;
            CurrentY = selectednode.CurrentY;
          

           


        }



        void CalculateNode(int NextNodeX, int NextNodeY)
        {
            bool found = false;
            AStarNode selectednode = new AStarNode(-1, -1);

            foreach (AStarNode m in OpenNodes)
            {
                if (NextNodeX == m.CurrentX && NextNodeY == m.CurrentY)
                {
                    found = true;
                    if (m.FCost >= CalculateG(NextNodeX, NextNodeY) + CalculateH(NextNodeX, NextNodeY))
                    {
                        selectednode = m;
                    }

                }

            }
            OpenNodes.Remove(selectednode);
            OpenNodes.Add(new AStarNode(CurrentX, CurrentY, NextNodeX, NextNodeY, CalculateG(NextNodeX, NextNodeY), CalculateH(NextNodeX, NextNodeY)));
            if (!found)
                OpenNodes.Add(new AStarNode(CurrentX, CurrentY, NextNodeX, NextNodeY, CalculateG(NextNodeX, NextNodeY), CalculateH(NextNodeX, NextNodeY)));
        }

        public int CalculateG(int NextNodeX, int NextNodeY)
        {
            int DisX = Math.Abs(NextNodeX - StartingX);
            int DisY = Math.Abs(NextNodeY - StartingY);
            int GValue;

            if (DisX > DisY)
                return GValue = (DisX - DisY) * 10 + DisY * 14;
            else
                return GValue = (DisY - DisX) * 10 + DisX * 14;
        }

        public int CalculateH(int NextNodeX, int NextNodeY)
        {
            int DisX = Math.Abs(TargetX - NextNodeX);
            int DisY = Math.Abs(TargetY - NextNodeY);
            int HValue;

            if (DisX > DisY)
                return HValue = (DisX - DisY) * 10 + DisY * 14;
            else
                return HValue = (DisY - DisX) * 10 + DisX * 14;
        }

        void CheckNeighbours()
        {
            bool exist = false;
            foreach (AStarNode node in Neighbors)
            {
                exist = false;
                foreach (AStarNode m in ClosedNodes)
                {
                    if (m.CurrentX == node.CurrentX && m.CurrentY == node.CurrentY)
                    {
                        exist = true;
                    }
                }
                foreach (AStarNode m in OpenNodes)
                {
                    if (m.CurrentX == node.CurrentX && m.CurrentY == node.CurrentY)
                    {
                        exist = true;
                    }

                }
                if (!exist)
                    CalculateNode(node.CurrentX, node.CurrentY);
            }
            
        }

        void FindNeighbors()
        {
            Neighbors.Clear();
            if (Map.WorldMap[CurrentX, CurrentY - 1])
                Neighbors.Add(new AStarNode(CurrentX, CurrentY - 1));

            if (Map.WorldMap[CurrentX + 1, CurrentY - 1])
                Neighbors.Add(new AStarNode(CurrentX + 1, CurrentY - 1));

            if (Map.WorldMap[CurrentX + 1, CurrentY])
                Neighbors.Add(new AStarNode(CurrentX + 1, CurrentY));

            if (Map.WorldMap[CurrentX + 1, CurrentY + 1])
                Neighbors.Add(new AStarNode(CurrentX + 1, CurrentY + 1));

            if (Map.WorldMap[CurrentX, CurrentY + 1])
                Neighbors.Add(new AStarNode(CurrentX, CurrentY + 1));

            if (Map.WorldMap[CurrentX - 1, CurrentY + 1])
                Neighbors.Add(new AStarNode(CurrentX - 1, CurrentY + 1));

            if (Map.WorldMap[CurrentX - 1, CurrentY])
                Neighbors.Add(new AStarNode(CurrentX - 1, CurrentY));

            if (Map.WorldMap[CurrentX - 1, CurrentY - 1])
                Neighbors.Add(new AStarNode(CurrentX - 1, CurrentY - 1));
        }

        public bool Finish()
        {
            if (CurrentX == TargetX && CurrentY == TargetY)
            {
                Console.WriteLine("Reached the Finish Line");
                return true;
            }
            return false;
        }

        public void BestPath()
        {
            //Console.WriteLine(ClosedNodes.Last().ParentX+","+ ClosedNodes.Last().ParentY);

            int retracingX = ClosedNodes.Last().ParentX, retracingY = ClosedNodes.Last().ParentY;

            while (!(retracingX == StartingX && retracingY == StartingY))
            {
                foreach (AStarNode m in ClosedNodes)
                {
                    if (m.CurrentX == retracingX && m.CurrentY == retracingY)
                    {
                        Console.WriteLine((retracingX) + "," + (retracingY));
                        retracingX = m.ParentX;
                        retracingY = m.ParentY;
                    }

                }

            }

            Console.WriteLine("Reached the Start Line");




        }





    }
}

