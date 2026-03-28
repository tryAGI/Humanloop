#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Remove Prompt Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RemovePromptDeploymentAsync(
            string id,
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}