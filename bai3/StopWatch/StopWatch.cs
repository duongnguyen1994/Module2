using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        public DateTime StartTime => startTime;
        private DateTime endTime;
        public DateTime EndTime => endTime;
        public StopWatch()
        {
            startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void End()
        {
            endTime = DateTime.Now;
        }
        public TimeSpan GetElapsedTime()
        {
            return endTime - startTime;
        }
    }
}