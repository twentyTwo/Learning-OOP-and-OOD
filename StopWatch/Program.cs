using System;


namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("1 to start and 2 to stop");
            while (true)
            {
                
                int cmmd = int.Parse(Console.ReadLine());

                if (cmmd == 1)
                {
                    try
                    {
                        stopwatch.Start();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Stopwatch is running..");
                    }
                    
                }
                if (cmmd == 2)
                {
                    try
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Duration is {stopwatch.Duration.Seconds} seconds");
                        
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Stopwatch is stop.");
                    }
                    
                }


            }


        }
    }
}
