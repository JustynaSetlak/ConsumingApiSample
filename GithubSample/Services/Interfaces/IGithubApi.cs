using System.Collections.Generic;
using System.Threading.Tasks;
using GithubSample.Models;
using Refit;

namespace GithubSample.Services.Interfaces
{
    [Headers("User-Agent: Test App")]
    public interface IGithubApi
    {
        [Get("/users/{username}/repos")]
        Task<List<Repository>> GetRepos(string username);

        [Get("/repos/{owner}/{repo}")]
        Task<Repository> GetRepoDetail(string owner, string repo);

        [Get("/repos/{owner}/{repo}/git/commits/{sha}")]
        Task<Commit> GetCommit([AliasAs("owner")] string username, string repo, [AliasAs("sha")] string commitIdentifier);
    }
}