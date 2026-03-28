#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Get Evaluator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluatorResponse> GetEvaluatorAsync(
            string id,
            string? versionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}