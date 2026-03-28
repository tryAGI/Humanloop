/* order: 20, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;
using tryAGI.Humanloop;

namespace Humanloop.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void CreateListPromptsTool()
    {
        var client = GetAuthenticatedClient();

        //// Create an AIFunction tool that lists prompts.
        //// This tool can be used with any IChatClient for function calling.
        var tool = client.AsListPromptsTool();

        Assert.IsNotNull(tool);
        Assert.AreEqual("humanloop_list_prompts", tool.Name);
        Console.WriteLine($"Tool: {tool.Name}");
        Console.WriteLine($"Description: {tool.Description}");
    }

    [TestMethod]
    public void CreateGetPromptTool()
    {
        var client = GetAuthenticatedClient();

        //// Create an AIFunction tool that retrieves a specific prompt by ID.
        var tool = client.AsGetPromptTool();

        Assert.IsNotNull(tool);
        Assert.AreEqual("humanloop_get_prompt", tool.Name);
        Console.WriteLine($"Tool: {tool.Name}");
        Console.WriteLine($"Description: {tool.Description}");
    }

    [TestMethod]
    public void CreateListEvaluationsTool()
    {
        var client = GetAuthenticatedClient();

        //// Create an AIFunction tool that lists evaluations.
        var tool = client.AsListEvaluationsTool();

        Assert.IsNotNull(tool);
        Assert.AreEqual("humanloop_list_evaluations", tool.Name);
        Console.WriteLine($"Tool: {tool.Name}");
        Console.WriteLine($"Description: {tool.Description}");
    }

    [TestMethod]
    public void CreateListDatasetsTool()
    {
        var client = GetAuthenticatedClient();

        //// Create an AIFunction tool that lists datasets.
        var tool = client.AsListDatasetsTool();

        Assert.IsNotNull(tool);
        Assert.AreEqual("humanloop_list_datasets", tool.Name);
        Console.WriteLine($"Tool: {tool.Name}");
        Console.WriteLine($"Description: {tool.Description}");
    }

    [TestMethod]
    public void CreateAllTools()
    {
        var client = GetAuthenticatedClient();

        //// Create all available Humanloop tools at once for use with any IChatClient.
        var tools = new AIFunction[]
        {
            client.AsListPromptsTool(),
            client.AsGetPromptTool(),
            client.AsListEvaluationsTool(),
            client.AsListDatasetsTool(),
        };

        Assert.AreEqual(4, tools.Length);
        foreach (var tool in tools)
        {
            Console.WriteLine($"  - {tool.Name}: {tool.Description}");
        }
    }
}
