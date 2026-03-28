#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Delete Evaluator
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEvaluatorAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}