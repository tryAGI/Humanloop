#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Upsert Flow
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.FlowResponse> UpsertFlowAsync(

            global::tryAGI.Humanloop.FlowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Flow
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.FlowResponse> UpsertFlowAsync(
            string? path = default,
            string? id = default,
            object? attributes = default,
            string? versionName = default,
            string? versionDescription = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? readme = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}