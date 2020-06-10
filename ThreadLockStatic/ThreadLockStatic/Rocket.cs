using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLockStatic
{
    public class Rocket
    {
       // public static bool IsRunnning = true;
        private int threadNum;
        private Simulator simulator;
        public Rocket(int threadNum, Simulator isRunningSimluator)
        {
            this.threadNum = threadNum;
            this.simulator = isRunningSimluator;
        }


        public void RocketOperations()
        {
            while (true)
            {
                if (!this.simulator.Running)
                {
                    Console.WriteLine($"Rocket num {this.threadNum} is photographing  ");

                }
                Thread.Sleep(10);

                if (!this.simulator.Running)
                {
                    Thread.Sleep(10000);
                }

            } 
            


            //for (int i=0; i<10; i++)
            //{
            //    for (int j=0; j<10; j++)
            //    {
            //        Console.WriteLine("Start for");
            //        break;
            //        Console.WriteLine("End for");
            //    }
            //    break;
            //}
        }
    }
}
