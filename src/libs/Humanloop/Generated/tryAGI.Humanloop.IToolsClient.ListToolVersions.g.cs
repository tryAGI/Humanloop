#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Tool Versions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ToolResponse>> ListToolVersionsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}