#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Set Agent Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.AgentResponse> SetAgentDeploymentAsync(
            string id,
            string environmentId,

            global::tryAGI.Humanloop.SetDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Agent Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.AgentResponse> SetAgentDeploymentAsync(
            string id,
            string environmentId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}