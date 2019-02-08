using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAIProgrammingExercise1
{
    public class AgentClass
    {



        int currentPosX, currentPosY;
        int TargetX, TargetY;

        public AgentClass(int StartX, int StartY, int FinalX, int FinalY)
        {
            currentPosX = StartX;
            currentPosY = StartY;

            TargetX = FinalX;
            TargetY = FinalY;

        }
        

        public bool CheckRightSpace()
        {

            return Map.WorldMap[currentPosX + 1, currentPosY];
           
        }
        public bool CheckLeftSpace()
        {

            return Map.WorldMap[currentPosX - 1, currentPosY];

        }

        public bool CheckUpSpace()
        {

            return Map.WorldMap[currentPosX, currentPosY - 1];

        }

        public bool CheckDownSpace()
        {

            return Map.WorldMap[currentPosX, currentPosY + 1];

        }



        public void Movement()
        {
            if(!Finish())
            {
               if(TargetX >= currentPosX && TargetY >= currentPosY)
                {
                    if (CheckRightSpace())
                    {
                        currentPosX += 1;
                    }
                    else if (CheckDownSpace())
                    {
                        currentPosY += 1;
                    }
                    else if (CheckUpSpace()) //Bouncing up and down
                    {
                        currentPosY -= 1;
                    }
                    else if (CheckLeftSpace())
                    {
                        currentPosX -= 1;
                    }
                }
               else if (TargetX <= currentPosX && TargetY >= currentPosY)
                {
                    if (CheckLeftSpace())
                    {
                        currentPosX -= 1;
                    }
                    else if (CheckDownSpace())
                    {
                        currentPosY += 1;
                    }
                    else if (CheckUpSpace()) //Bouncing up and down
                    {
                        currentPosY -= 1;
                    }
                    else if (CheckRightSpace())
                    {
                        currentPosX += 1;
                    }
                }
                else if (TargetX <= currentPosX && TargetY <= currentPosY)
                {
                    if (CheckLeftSpace())
                    {
                        currentPosX -= 1;
                    }
                    else if (CheckUpSpace()) //Bouncing up and down
                    {
                        currentPosY -= 1;
                    }
                    else if (CheckDownSpace())
                    {
                        currentPosY += 1;
                    }
                    else if (CheckRightSpace())
                    {
                        currentPosX += 1;
                    }
                }
                else if (TargetX >= currentPosX && TargetY <= currentPosY)
                {
                    if (CheckRightSpace())
                    {
                        currentPosX += 1;
                    }
                    else if (CheckUpSpace()) //Bouncing up and down
                    {
                        currentPosY -= 1;
                    }
                    else if (CheckDownSpace())
                    {
                        currentPosY += 1;
                    }
                    else if (CheckLeftSpace())
                    {
                        currentPosX -= 1;
                    }
                }
                Console.WriteLine((currentPosX-1) + " , " + (currentPosY-1));
            }

           

        }

        public bool Finish()
        {
            if (currentPosX == TargetX && currentPosY == TargetY)
            {
                Console.WriteLine("Reached the Finish Line");

                return true;
            }
                

            return false;
        }


    }


}
