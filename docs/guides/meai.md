# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Humanloop SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Humanloop's prompt management, versioning, evaluations, and dataset management.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsListPromptsTool()` | List available prompts with optional name filter and pagination |
| `AsGetPromptTool()` | Get prompt details by ID, including template, model config, and versions |
| `AsListEvaluationsTool()` | List evaluations with status, run counts, and URLs |
| `AsListDatasetsTool()` | List datasets with datapoint counts and metadata |

## Usage

```csharp
using Microsoft.Extensions.AI;
using tryAGI.Humanloop;

// Create the Humanloop client
var humanloop = new HumanloopClient(apiKey: "hl_...");

// Create tools for use with any IChatClient
var tools = new AIFunction[]
{
    humanloop.AsListPromptsTool(),
    humanloop.AsGetPromptTool(),
    humanloop.AsListEvaluationsTool(),
    humanloop.AsListDatasetsTool(),
};

// Use with any IChatClient (e.g., OpenAI, Anthropic, Ollama)
var response = await chatClient.GetResponseAsync(
    "List all my prompts in Humanloop",
    new ChatOptions { Tools = [.. tools] });
```

## Tool Details

### `AsListPromptsTool()`

Lists prompts with optional filtering and pagination.

**Parameters:**
- `name` (optional): Case-insensitive name filter
- `page` (optional): Page number
- `size` (optional): Items per page

### `AsGetPromptTool()`

Retrieves detailed information about a specific prompt.

**Parameters:**
- `id` (required): The prompt's unique identifier
- `versionId` (optional): Specific version to retrieve
- `environment` (optional): Environment name for deployed version

### `AsListEvaluationsTool()`

Lists evaluations with their status and metrics.

**Parameters:**
- `fileId` (optional): Filter by associated file ID
- `page` (optional): Page number
- `size` (optional): Items per page

### `AsListDatasetsTool()`

Lists datasets with datapoint counts.

**Parameters:**
- `name` (optional): Case-insensitive name filter
- `page` (optional): Page number
- `size` (optional): Items per page
