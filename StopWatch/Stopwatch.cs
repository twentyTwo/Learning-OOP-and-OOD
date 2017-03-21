using System;

namespace StopWatch
{
    class Stopwatch
    {
        private bool _isRunning;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan Duration
        {
            get
            {
                return (EndTime - StartTime); 
            }
        }


        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is running.");
            }

            _isRunning = true;
            StartTime = DateTime.Now;          
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is stop.");
            }
            
            _isRunning = false;
            EndTime = DateTime.Now;
            

        }
    }
}