#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Update Evaluation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluationResponse> UpdateEvaluationAsync(
            string id,

            global::tryAGI.Humanloop.UpdateEvaluationStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Evaluation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluationResponse> UpdateEvaluationAsync(
            string id,
            global::tryAGI.Humanloop.UpdateEvaluationStatusRequestStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}