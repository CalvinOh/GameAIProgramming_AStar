using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAIProgrammingExercise1
{
    class Program
    {
        static void Main(string[] args)
        {


            Map.SetUp();
            Map.BuildWall();
            Map.Obstacles();

            /*
            AgentClass Agent = new AgentClass(1,1,10,10);



            while(!Agent.Finish())
            {
                Agent.Movement();
            }
            
            */

            AStarAgent ASAgent = new AStarAgent(1,1,10,10) ;

            while (!ASAgent.Finish())
            {
                ASAgent.SolvePuzzle();
                
            }

            Console.WriteLine("----------------------------------");

            ASAgent.BestPath();

            Console.Read();

        }
    }
}
