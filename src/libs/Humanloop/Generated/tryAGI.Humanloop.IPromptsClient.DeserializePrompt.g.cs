#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Deserialize Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PromptResponse> DeserializePromptAsync(

            global::tryAGI.Humanloop.DeserializePromptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deserialize Prompt
        /// </summary>
        /// <param name="content">
        /// Raw .prompt file content.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PromptResponse> DeserializePromptAsync(
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}