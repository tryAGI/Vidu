namespace Vidu.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ViduClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VIDU_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VIDU_API_KEY environment variable is not found.");

        var client = new ViduClient(apiKey);

        return client;
    }
}
