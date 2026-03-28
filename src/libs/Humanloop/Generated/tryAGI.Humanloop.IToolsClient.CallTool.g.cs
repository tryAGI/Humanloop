#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Call Tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.CallToolResponse> CallToolAsync(

            global::tryAGI.Humanloop.CallToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Tool
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="inputs"></param>
        /// <param name="traceParentId"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.CallToolResponse> CallToolAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            object? inputs = default,
            string? traceParentId = default,
            bool? save = default,
            string? logId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}