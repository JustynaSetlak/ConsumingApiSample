using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace GithubSample
{
    public class GithubService
    {
        private readonly string _apiAddress = "https://api.github.com";
        private readonly IGithubApi _githubApi;

        public GithubService()
        {
             _githubApi = RestService.For<IGithubApi>(_apiAddress);
        }

        public async Task<List<Repository>> GetRepos(string username)
        {
            var repos = await _githubApi.GetRepos(username);
            return repos;
        }

        public async Task<Repository> GetRepoDetail(string owner, string repoName)
        {
            var repository = await _githubApi.GetRepoDetail(owner, repoName);
            return repository;
        }

        public async Task<Commit> GetCommit(string username, string repo, string commitIdentifier)
        {
            var commit = await _githubApi.GetCommit(username, repo, commitIdentifier);
            return commit;
        }
    }
}