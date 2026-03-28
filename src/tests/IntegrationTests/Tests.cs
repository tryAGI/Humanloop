using tryAGI.Humanloop;

namespace Humanloop.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static HumanloopClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("HUMANLOOP_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("HUMANLOOP_API_KEY environment variable is not found.");

        var client = new HumanloopClient(apiKey);
        
        return client;
    }
}
