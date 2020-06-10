using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLockStatic
{
    class Program
    {

       
        static void Main(string[] args)
        {

            Simulator[] threadIsRunning = new Simulator[10];
            Thread[] rocketArr = new Thread[10];

            WatcherThread watcherThread = new WatcherThread(threadIsRunning);
            

            for (int i = 0; i < threadIsRunning.Length; i++)
            {
                threadIsRunning[i] = new Simulator();
                threadIsRunning[i].Running = true;
            }

            for (int i=0; i< rocketArr.Length; i++)
            {
                Rocket r1 = new Rocket(i, threadIsRunning[i]);

                rocketArr[i] = new Thread(new ThreadStart(r1.RocketOperations));
                rocketArr[i].Start();

            }



            Thread.Sleep(10000);
            //for (int i = 0; i < threadIsRunning.Length; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        threadIsRunning[i].Running = false;

            //    }
            //}

            Console.WriteLine("All even thread were stopped");
            int result = 0;
            while (result!=6)
            {
                Console.WriteLine("Please input thread ");
                int numOfThread = int.Parse(Console.ReadLine());
                watcherThread.PauseThread(numOfThread);
            }

           //ocket.IsRunnning = false;
            Console.ReadKey();

        }
    }
}
