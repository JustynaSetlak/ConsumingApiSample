using System;

namespace GithubSample.Models
{
    public class Commit
    {
        public Committer Committer { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"Message: {Message}, author name: {Committer.Email}, date: {Committer.Date}";
        }
    }

    public class Committer
    {
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}