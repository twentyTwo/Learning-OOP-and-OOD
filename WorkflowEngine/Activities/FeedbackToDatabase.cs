using System;
using System.Threading;

namespace Workflow.Activities
{
    internal class FeedbackToDatabase : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Feedback to database started.");
            Thread.Sleep(2000);
            Console.WriteLine("Feedback to datbase ends.");
        }
    }
}