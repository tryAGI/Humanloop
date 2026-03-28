#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Move Evaluator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluatorResponse> MoveEvaluatorAsync(
            string id,

            global::tryAGI.Humanloop.MoveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Evaluator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="path">
        /// New path to move the file to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.EvaluatorResponse> MoveEvaluatorAsync(
            string id,
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}