#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// List Flow Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.Humanloop.FlowResponse>> ListFlowVersionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}