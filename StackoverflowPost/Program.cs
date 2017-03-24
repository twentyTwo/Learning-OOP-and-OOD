using System;
using System.Collections.Generic;

namespace StackoverflowPost
{
    internal class Program
    {
        private static void Main()
        {
            List<StackOverflowPost> stackOverflowPostList = new List<StackOverflowPost>();
            var stackOverflowPost = new StackOverflowPost
            {
                Title = "Random Number",
                Description = "How to create a random number with the range of 1 to 100",
                PostDate = DateTime.Now
            };

            var stackOverflowPost1 = new StackOverflowPost
            {
                Title = "FIbonacci Number",
                Description = "What is the 10th fibonacci number?",
                PostDate = DateTime.Now
            };



            stackOverflowPostList.Add(stackOverflowPost);
            stackOverflowPostList.Add(stackOverflowPost1);

            while (true)
            {
                int sl = 0;
                foreach (var post in stackOverflowPostList)
                {
                    Console.WriteLine($"{++sl}. {post.Title}");
                }

                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Title: {stackOverflowPostList[n - 1].Title}" +
                                  $"\nDescription{stackOverflowPostList[n - 1].Description}" +
                                  $"\nPublished at: {stackOverflowPostList[n - 1].PostDate}  {stackOverflowPostList[n - 1].TotalVote}");
                Console.WriteLine();
                Console.WriteLine($"Total Vote: {stackOverflowPostList[n - 1].TotalVote}, UpVote {stackOverflowPostList[n - 1].UpVoteCount}, DownVote: {stackOverflowPostList[n - 1].DownVoteCount}");
                Console.WriteLine("Press 1 for upvote, 2 for downvote");
                int v = int.Parse(Console.ReadLine());
                if (v == 1)
                {
                    stackOverflowPostList[n - 1].PutUpVote();
                }
                else
                {

                    stackOverflowPostList[n - 1].PutDownVote();
                }
            }
        }
    }
}