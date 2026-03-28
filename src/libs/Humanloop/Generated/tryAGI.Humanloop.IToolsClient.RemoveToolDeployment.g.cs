#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Remove Tool Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveToolDeploymentAsync(
            string id,
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}