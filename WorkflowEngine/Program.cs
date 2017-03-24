using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Activities;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activityList = new List<IActivity>
            {
                new DecodeFile(),
                new UploadFileInAws(),
                new FeedbackToDatabase()
            };

            Workflow workflow = new Workflow(activityList);
            workflow.RunWorkflow();
        }
    }
}
