#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete Prompt Version
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptVersionAsync(
            string id,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}