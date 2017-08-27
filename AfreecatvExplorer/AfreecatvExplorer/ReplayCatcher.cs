using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AfreecatvExplorer
{
    class ReplayCatcher
    {
        public ReplayCatcher()
        {
            Thread thread = new Thread(new ThreadStart(taskFunc));
            thread.Start();
        }

        public void taskFunc()
        {
            while(true)
            {

            }
        }
    }
}
