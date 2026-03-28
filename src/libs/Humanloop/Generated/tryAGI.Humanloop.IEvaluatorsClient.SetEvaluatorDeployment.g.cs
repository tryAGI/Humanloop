#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Set Evaluator Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluatorResponse> SetEvaluatorDeploymentAsync(
            string id,
            string environmentId,

            global::tryAGI.Humanloop.SetDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Evaluator Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluatorResponse> SetEvaluatorDeploymentAsync(
            string id,
            string environmentId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}