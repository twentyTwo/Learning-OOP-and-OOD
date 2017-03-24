using System;
using System.Threading;

namespace Workflow.Activities
{
    public class DecodeFile : IActivity
    {
        public void Run()
        {
            Console.WriteLine("File decoding started..");
            Thread.Sleep(3000);
            Console.WriteLine("File decoded successfully.");
        }
    }
}