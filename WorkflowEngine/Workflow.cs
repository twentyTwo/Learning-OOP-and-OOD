using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Workflow.Activities;

namespace Workflow
{

    public class Workflow
    {
        private readonly List<IActivity> _activityList; 
        public Workflow(List<IActivity> activityList)
        {
            _activityList = activityList;
        }

        public void RunWorkflow()
        {
            foreach (var activity in _activityList)
            {
                activity.Run();
            }
        }
    }
}