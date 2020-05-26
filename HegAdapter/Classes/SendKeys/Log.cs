using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter {
    class Log {
        private DateTime Started;
        private string EventDesc;
        public Log(string eventDesc) {
            EventDesc = eventDesc;
        }

        public void Start() {
            Started = DateTime.Now;
            Console.WriteLine(string.Format("{0} Start: {1}", EventDesc, Started));
        }

        public void Stop() {
            DateTime stopped = DateTime.Now;
            TimeSpan time = stopped - Started;
            Console.WriteLine(string.Format("{0}  Stop: {1}", EventDesc, stopped));
            Console.WriteLine(string.Format("{0}  Time: {1}", EventDesc, time.TotalMilliseconds)); 
        }
    }
}
