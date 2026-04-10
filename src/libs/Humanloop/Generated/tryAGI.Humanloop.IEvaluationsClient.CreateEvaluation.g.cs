#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Create Evaluation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluationResponse> CreateEvaluationAsync(

            global::tryAGI.Humanloop.EvaluationRequest request,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Evaluation
        /// </summary>
        /// <param name="fileId">
        /// ID of the File to evaluate.
        /// </param>
        /// <param name="name">
        /// Name of the Evaluation.
        /// </param>
        /// <param name="evaluatorIds">
        /// IDs of Evaluators to use.
        /// </param>
        /// <param name="datasetId">
        /// ID of the Dataset to use.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluationResponse> CreateEvaluationAsync(
            string? fileId = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? evaluatorIds = default,
            string? datasetId = default,
            global::tryAGI.Humanloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}