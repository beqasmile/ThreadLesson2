using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLock
{
    class Program
    {
        static bool done;
       
        static readonly object locker = new object();
        static void Main(string[] args)
        {
            new Thread(x=>Go(1)).Start();
            new Thread(x=>Go(2)).Start();

            new Thread(x=>Go(3)).Start();
            Go(0);


            Console.ReadKey();
        }

        static void Go(int threadNum)
        {

            //lock (locker)
            //{
            //    if (!done)
            //    {
            //        done = true;
            //        Console.WriteLine("Done");
            //    }

            //}

           // lock (locker)
            //{
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"{i} Thread number {threadNum} ");
                }
                Console.WriteLine("Finishing thread  --------------------------------------");
                Thread.Sleep(2000);

            //}

        }
    }
}
