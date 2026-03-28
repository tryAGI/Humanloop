#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Populate Prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PopulatePromptResponse> PopulatePromptAsync(
            string id,

            global::tryAGI.Humanloop.PopulatePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate Prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PopulatePromptResponse> PopulatePromptAsync(
            string id,
            object? inputs = default,
            string? versionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}