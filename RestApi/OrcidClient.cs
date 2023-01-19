using MyApp;
using RestApi;
using RestSharp;

public class OrcidClient : IOrcidInterface, IDisposable
{
    readonly RestClient _client;

    public OrcidClient(string apiKey, string apiKeySecret)
    {
        var options = new RestClientOptions("https://api.twitter.com/2");

        _client = new RestClient(options)
        {
            Authenticator = new OrcidAuthenticator("https://api.twitter.com", apiKey, apiKeySecret)
        };
    }

    public async Task<Test> GetUser(string user)
    {
        var response = await _client.GetJsonAsync<TestSingleObject<Test>>(
            "users/by/username/{user}",
            new { user }
        );
        return response!.Data;
    }

    record TestSingleObject<T>(T Data);

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}