#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Update Flow Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.FlowResponse> UpdateFlowMonitoringAsync(
            string id,

            global::tryAGI.Humanloop.UpdateMonitoringRequest request,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Flow Monitoring
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activate"></param>
        /// <param name="deactivate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.FlowResponse> UpdateFlowMonitoringAsync(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestActivateItem>? activate = default,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestDeactivateItem>? deactivate = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}