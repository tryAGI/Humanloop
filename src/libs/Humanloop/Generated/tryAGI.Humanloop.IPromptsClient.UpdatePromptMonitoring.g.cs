#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update Prompt Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PromptResponse> UpdatePromptMonitoringAsync(
            string id,

            global::tryAGI.Humanloop.UpdateMonitoringRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Prompt Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PromptResponse> UpdatePromptMonitoringAsync(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestActivateItem>? activate = default,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestDeactivateItem>? deactivate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}