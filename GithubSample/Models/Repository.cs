namespace GithubSample.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return $"RepoName: {Name}, Description: {Description}, Url: {Url}";
        }
    }
}