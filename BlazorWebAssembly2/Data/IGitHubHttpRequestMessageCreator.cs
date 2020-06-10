using System.Net.Http;

namespace BlazorWebAssembly2.Data
{
    public interface IGitHubHttpRequestMessageCreator
    {
        HttpRequestMessage Create(string pathToGitHub);
    }
}