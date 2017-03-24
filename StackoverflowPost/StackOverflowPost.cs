using System;

namespace StackoverflowPost
{
    public class StackOverflowPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public int UpVoteCount { get; private set; }
        public int DownVoteCount { get; private set; }

        public int TotalVote
        {
            get { return UpVoteCount - DownVoteCount; }
        }

        public void PutUpVote()
        {
            UpVoteCount += 1;
        }

        public void PutDownVote()
        {
            DownVoteCount += 1;
        }
    }
}