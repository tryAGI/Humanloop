#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Call Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.AgentCallResponse> CallAgentAsync(

            global::tryAGI.Humanloop.AgentCallRequest request,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Agent
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="messages"></param>
        /// <param name="agent"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="traceParentId"></param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.AgentCallResponse> CallAgentAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ChatMessage>? messages = default,
            global::tryAGI.Humanloop.AgentRequest? agent = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            bool? save = default,
            string? logId = default,
            string? traceParentId = default,
            string? user = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}