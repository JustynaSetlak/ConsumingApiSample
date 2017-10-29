using System;
using System.Collections.Generic;
using GithubSample.Models;
using GithubSample.Services;

namespace GithubSample
{
    class Program
    {
        static void Main(string[] args)
        {
            GithubService githubService = new GithubService();
            const string userName = "justynasetlak";
            const string repoName = "ConsumingApiSample";
            const string commitIdentifier = "e77bb55976670c98b18caaa1d5160ce6af626740";

            List<Repository> repositories = githubService.GetRepos(userName).Result;
            Console.WriteLine("List Of Repositories: ");
            repositories.ForEach(o => Console.Write($"{o.Name}, "));
            Console.WriteLine("\n");

            Repository repository = githubService.GetRepoDetail(userName, repoName).Result;
            Console.WriteLine("Repository details: ");
            Console.WriteLine(repository.ToString());
            Console.WriteLine("\n");

            Commit commit = githubService.GetCommit(userName, repoName, commitIdentifier).Result;
            Console.WriteLine("commit details: ");
            Console.WriteLine(commit.ToString());
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
