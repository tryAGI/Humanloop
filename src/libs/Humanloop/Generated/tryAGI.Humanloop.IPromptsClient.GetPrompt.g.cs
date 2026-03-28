#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get Prompt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PromptResponse> GetPromptAsync(
            string id,
            string? versionId = default,
            string? environment = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}