using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace tryAGI.Humanloop;

/// <summary>
/// Extension methods for creating MEAI <see cref="AIFunction"/> tools from <see cref="HumanloopClient"/>.
/// </summary>
public static class HumanloopClientToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> tool that lists available Prompts in Humanloop.
    /// </summary>
    /// <param name="client">The Humanloop client instance.</param>
    /// <returns>An <see cref="AIFunction"/> that can be used with any <see cref="IChatClient"/>.</returns>
    public static AIFunction AsListPromptsTool(this HumanloopClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Optional name filter for prompts")] string? name = null,
                [Description("Page number (starting from 1)")] int? page = null,
                [Description("Number of items per page")] int? size = null,
                CancellationToken cancellationToken = default) =>
            {
                var response = await client.Prompts.ListPromptsAsync(
                    page: page,
                    size: size,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Total,
                    response.Page,
                    response.Size,
                    Prompts = response.Records.Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.Path,
                        p.Model,
                        p.VersionId,
                        p.Description,
                        p.CreatedAt,
                        p.UpdatedAt,
                        p.TotalLogsCount,
                    }),
                };
            },
            name: "humanloop_list_prompts",
            description: "List available prompts in Humanloop. Returns prompt names, IDs, models, and metadata. " +
                         "Supports filtering by name and pagination.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> tool that retrieves a specific Prompt by ID from Humanloop.
    /// </summary>
    /// <param name="client">The Humanloop client instance.</param>
    /// <returns>An <see cref="AIFunction"/> that can be used with any <see cref="IChatClient"/>.</returns>
    public static AIFunction AsGetPromptTool(this HumanloopClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("The unique identifier of the prompt to retrieve")] string id,
                [Description("Optional specific version ID to retrieve")] string? versionId = null,
                [Description("Optional environment name to retrieve the deployed version for")] string? environment = null,
                CancellationToken cancellationToken = default) =>
            {
                var response = await client.Prompts.GetPromptAsync(
                    id: id,
                    versionId: versionId,
                    environment: environment,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    response.Path,
                    response.Model,
                    response.VersionId,
                    response.VersionName,
                    response.Description,
                    response.Provider,
                    response.Temperature,
                    response.MaxTokens,
                    response.CreatedAt,
                    response.UpdatedAt,
                    response.TotalLogsCount,
                    response.VersionLogsCount,
                    TemplateMessages = response.Template?.Select(m => new
                    {
                        m.Role,
                        m.Content,
                    }),
                    ToolCount = response.Tools?.Count ?? 0,
                    Tags = response.Tags,
                };
            },
            name: "humanloop_get_prompt",
            description: "Get details of a specific prompt in Humanloop by its ID. " +
                         "Returns prompt configuration including model, template, parameters, and version info. " +
                         "Optionally retrieve a specific version or deployed version for an environment.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> tool that lists Evaluations in Humanloop.
    /// </summary>
    /// <param name="client">The Humanloop client instance.</param>
    /// <returns>An <see cref="AIFunction"/> that can be used with any <see cref="IChatClient"/>.</returns>
    public static AIFunction AsListEvaluationsTool(this HumanloopClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Optional file ID to filter evaluations")] string? fileId = null,
                [Description("Page number")] int? page = null,
                [Description("Number of items per page")] int? size = null,
                CancellationToken cancellationToken = default) =>
            {
                var response = await client.Evaluations.ListEvaluationsAsync(
                    page: page,
                    size: size,
                    fileId: fileId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Total,
                    response.Page,
                    response.Size,
                    Evaluations = response.Records.Select(e => new
                    {
                        e.Id,
                        e.Name,
                        e.FileId,
                        e.Status,
                        e.RunsCount,
                        e.CreatedAt,
                        e.UpdatedAt,
                        e.Url,
                        EvaluatorCount = e.Evaluators.Count,
                    }),
                };
            },
            name: "humanloop_list_evaluations",
            description: "List evaluations in Humanloop. Returns evaluation names, statuses, run counts, and URLs. " +
                         "Supports filtering by file ID and pagination.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> tool that lists Datasets in Humanloop.
    /// </summary>
    /// <param name="client">The Humanloop client instance.</param>
    /// <returns>An <see cref="AIFunction"/> that can be used with any <see cref="IChatClient"/>.</returns>
    public static AIFunction AsListDatasetsTool(this HumanloopClient client)
    {
        return AIFunctionFactory.Create(
            async (
                [Description("Optional name filter for datasets")] string? name = null,
                [Description("Page number")] int? page = null,
                [Description("Number of items per page")] int? size = null,
                CancellationToken cancellationToken = default) =>
            {
                var response = await client.Datasets.ListDatasetsAsync(
                    page: page,
                    size: size,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Total,
                    response.Page,
                    response.Size,
                    Datasets = response.Records.Select(d => new
                    {
                        d.Id,
                        d.Name,
                        d.Path,
                        d.VersionId,
                        d.Description,
                        d.DatapointsCount,
                        d.CreatedAt,
                        d.UpdatedAt,
                    }),
                };
            },
            name: "humanloop_list_datasets",
            description: "List datasets in Humanloop. Returns dataset names, IDs, datapoint counts, and metadata. " +
                         "Supports filtering by name and pagination.");
    }
}
