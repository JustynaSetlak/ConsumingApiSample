using System;
using System.Collections.Generic;

namespace GithubSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GithubService githubService = new GithubService();
            List<Repository> repositories = githubService.GetRepos("justynasetlak").Result;
            Console.WriteLine("List Of Repositories: ");
            repositories.ForEach(o => Console.Write($"{o.Name}, "));
            Console.WriteLine("\n");

            Repository repository = githubService.GetRepoDetail("justynasetlak", "ConsumingApiSample").Result;
            Console.WriteLine("Repository details: ");
            Console.WriteLine(repository.ToString());
            Console.WriteLine("\n");

            Commit commit = githubService.GetCommit("justynasetlak", "ConsumingApiSample", "e77bb55976670c98b18caaa1d5160ce6af626740").Result;
            Console.WriteLine("commit details: ");
            Console.WriteLine(commit.ToString());
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
