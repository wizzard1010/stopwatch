using System;
using System.Threading;

namespace stopwatch
{
    public class Stopwatch
    {
        public bool isRunning;
        public DateTime startTime;
        public DateTime stopTime;

        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("Stop watch is already starting");
            }
            isRunning = true;
            startTime = DateTime.Now;
            Console.WriteLine("Stopwatch started");
        }
        public void Stop()
        {
            if (!isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }
            stopTime = DateTime.Now;
            isRunning = false;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine("Duration: {0}", duration);
        }
    }
}
