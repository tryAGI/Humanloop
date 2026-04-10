#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Upsert Tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.ToolResponse> UpsertToolAsync(

            global::tryAGI.Humanloop.ToolRequest request,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Tool
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="function"></param>
        /// <param name="sourceCode"></param>
        /// <param name="setupValues"></param>
        /// <param name="attributes"></param>
        /// <param name="toolType"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.ToolResponse> UpsertToolAsync(
            string? path = default,
            string? id = default,
            global::tryAGI.Humanloop.ToolFunction? function = default,
            string? sourceCode = default,
            object? setupValues = default,
            object? attributes = default,
            string? toolType = default,
            string? versionName = default,
            string? versionDescription = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}