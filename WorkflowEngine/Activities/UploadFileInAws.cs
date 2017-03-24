using System;
using System.Threading;

namespace Workflow.Activities
{
    public class UploadFileInAws : IActivity
    {
        public void Run()
        {
            Console.WriteLine("File uploading started..");
            Thread.Sleep(2000);
            Console.WriteLine("File uploaded successfully.");
        }
    }
}