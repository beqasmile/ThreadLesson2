using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLockStatic
{
    public class WatcherThread
    {
        private Simulator[] simulatorArray;
        public WatcherThread(Simulator[] simulators)
        {
            this.simulatorArray = simulators;
        }


        

        public void PauseThread (int num)
        {
            simulatorArray[num].Running = true;
        }

        public void ContinueThread(int num)
        {
            simulatorArray[num].Running = false ;

        }
    }
}
