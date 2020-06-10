using System.Threading.Tasks;

namespace BlazorWebAssembly2.Data
{
    public interface IGitHubUserSearchService
    {
        Task<GitHubUser> GetGitHubUser(string username);
    }
}