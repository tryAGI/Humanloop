#nullable enable

namespace tryAGI.Humanloop
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.Humanloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.Humanloop.PaginatedEvaluationResponse> ListEvaluationsAsync(
            int? page = default,
            int? size = default,
            string? fileId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}