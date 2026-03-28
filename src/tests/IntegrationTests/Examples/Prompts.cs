/* order: 10, title: Prompts, slug: prompts */

using tryAGI.Humanloop;

namespace Humanloop.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListPrompts()
    {
        var client = GetAuthenticatedClient();

        //// List all prompts in your Humanloop workspace.
        var response = await client.Prompts.ListPromptsAsync(
            size: 10);

        Assert.IsNotNull(response);
        Assert.IsNotNull(response.Records);
        Console.WriteLine($"Found {response.Total} prompts");

        foreach (var prompt in response.Records)
        {
            Console.WriteLine($"  - {prompt.Name} (model: {prompt.Model}, version: {prompt.VersionId})");
        }
    }

    [TestMethod]
    public async Task UpsertPrompt()
    {
        var client = GetAuthenticatedClient();

        //// Create or update a prompt. If a prompt with the same path
        //// already exists and the config is different, a new version
        //// will be created automatically.
        var response = await client.Prompts.UpsertPromptAsync(
            request: new PromptRequest
            {
                Path = "test-sdk/greeting",
                Model = "gpt-4o",
                Template =
                [
                    new ChatMessage
                    {
                        Role = ChatMessageRole.System,
                        Content = "You are a helpful assistant that greets users warmly.",
                    },
                ],
                Temperature = 0.7,
                MaxTokens = 256,
                VersionName = "v1-greeting",
            });

        Assert.IsNotNull(response);
        Assert.IsNotNull(response.Id);
        Console.WriteLine($"Prompt ID: {response.Id}, Version: {response.VersionId}");
    }
}
